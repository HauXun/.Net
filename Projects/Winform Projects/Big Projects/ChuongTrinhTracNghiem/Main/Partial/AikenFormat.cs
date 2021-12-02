using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Main.Partial
{
	public class AikenFormat
	{
		public string SubjectID { get; set; }
		public string ExamID { get; set; }
		public List<Question> Questions { get; set; }
		public int LimitPush { get; set; }

		public AikenFormat(DataRowCollection dataRow)
		{
			CheckingFormat(dataRow);
		}

		private void CheckingFormat(DataRowCollection dataRow)
		{
			Exam exam = null;
			Questions = new List<Question>();
			Question question = new Question();
			string[] answer = new string[4];
			int i = 2;

			foreach (DataRow item in dataRow)
			{
				string col_1 = item[0].ToString().Trim();
				if (!string.IsNullOrEmpty(col_1))
				{
					string col_2 = item[1].ToString().Trim();
					switch (col_1)
					{
						case "Mã môn thi:":
							SubjectID = col_2;
							Subject subject = SubjectBLL.Instance.GetSubjectByID(SubjectID);
							if (subject == null)
							{
								throw new Exception($"Không tồn tại môn này trong dữ liệu hệ thống, xem lại mã môn ở dòng {i} trong" +
									$" file tài liệu nhé !!!");
							}
							break;
						case "Mã đề thi:":
							ExamID = col_2;
							exam = ExistExam(SubjectID);
							if (exam == null)
							{
								throw new Exception($"Không tồn tại mã đề thi của môn này trong dữ liệu hệ thống, xem lại mã đề ở" +
									$" dòng {i} trong file tài liệu nhé !!!");
							}
							break;
						case "Question:":
							if (string.IsNullOrEmpty(col_2))
							{
								throw new Exception($"Nội dung câu hỏi ở dòng dòng thứ {i} bị thiếu này, xem lại và bổ sung nội dung" +
									$" câu hỏi cho câu này ở dòng {i} trong file tài liệu nhé !!!");
							}
							question.QContent = col_2;
							break;
						case "A.":
							answer[0] = col_2;
							question.OptionA = col_2;
							break;
						case "B.":
							answer[1] = col_2;
							question.OptionB = col_2;
							break;
						case "C.":
							answer[2] = col_2;
							question.OptionC = col_2;
							break;
						case "D.":
							answer[3] = col_2;
							question.OptionD = col_2;
							break;
						case "Answer:":
							if (string.IsNullOrEmpty(col_2))
							{
								throw new Exception($"Đáp án đúng của câu hỏi dòng thứ {i} bị thiếu này, xem lại và bổ sung đáp án" +
									$" đúng cho câu này ở dòng {i} trong file tài liệu nhé !!!");
							}
							else if (!answer.Contains(col_2))
							{
								throw new Exception($"Đáp án đúng không khớp với một trong các câu trả lời của câu hỏi này, xem lại" +
									$" đáp án đúng ở dòng {i} trong file tài liệu nhé !!!");
							}
							else if (answer.Contains(col_2))
							{
								question.Answer = col_2;
								Questions.Add(question);
								question = new Question();
							}
							break;
					}
				}
				i++;
			}

			int qCount = Questions.Count;
			LimitPush = exam.QCount - exam.QCurrentCount;
			if (qCount > LimitPush && LimitPush > 0)
			{
				if (MsgBox.ShowMessage($"Đề thi {exam.ExamID} môn {exam.SubjectID} giới hạn {exam.QCount} câu hỏi và hiện có sẵn" +
					$" {exam.QCurrentCount}. Bạn có muốn tải lên {LimitPush}/{qCount} câu hỏi từ file dữ liệu không ? {qCount - LimitPush}" +
					$" câu hỏi cuối cùng của file dữ liệu sẽ được hệ thống tự động bỏ qua", "Nhắc nhở!",
					MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.No)
				{
					throw new Exception("Thao tác đã được hủy !!!");
				}
			}
			else if (LimitPush <= 0)
			{
				throw new Exception($"Đề thi {exam.ExamID} môn {exam.SubjectID} giới hạn {exam.QCount} câu hỏi." +
					$" Không thể tải lên {qCount} câu hỏi từ file dữ liệu nữa !!!");
			}
		}

		private Exam ExistExam(string subjectID)
		{
			DataTable data = ExamBLL.Instance.GetExamByIDSubject(subjectID);
			foreach (DataRow row in data.Rows)
			{
				Exam exam = new Exam(row);
				if (string.Compare(exam.ExamID, ExamID, true) == 0)
				{
					ExamID = exam.ExamID;
					SubjectID = exam.SubjectID;
					return exam;
				}
			}
			return null;
		}
	}
}
