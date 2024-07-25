// internal class Program
// {
//     static void Main(string[] args)
//     {
//         int[] stdID = new int[3] { 10110101, 10210212, 10310313 };
//         string[] stdNames = new string[3] { "Hesam", "Tony", "Adam" };
//         double[,] stdMarks = new double[3, 8] {
//             { 80, 90, 70, 85, 80, 50, 60, 100 },
//             { 78, 70, 95, 75, 85, 100, 50, 68 },
//             { 70, 55, 65, 75, 45, 50, 40, 50 }
//         };

//         string[] courseContent = new string[8] { "Midterm", "Final", "Lab Test 1",
//                                                   "Lab Test 2", "Quizzes", "Lab Activities",
//                                                   "Assignment 1", "Assignment 2" };

//         double[] courseWeights = new double[8] { 0.2, 0.25, 0.1, 0.1, 0.08, 0.07, 0.1, 0.1 };

//         double sumFinals = 0;
//         for (int i = 0; i < stdMarks.GetLength(0); i++)
//         {
//             sumFinals += stdMarks[i, 1];
//         }
//         double avgFinals = sumFinals / stdMarks.GetLength(0);
//         Console.WriteLine($"The average of final marks is {avgFinals}");

//         double[] sumCourseContents = new double[courseContent.Length];
//         for (int i = 0; i < stdMarks.GetLength(0); i++)
//         {
//             for (int j = 0; j < stdMarks.GetLength(1); j++)
//             {
//                 sumCourseContents[j] += stdMarks[i, j];
//             }
//         }

//         Console.WriteLine("The average of each course content:");
//         for (int j = 0; j < sumCourseContents.Length; j++)
//         {
//             double avgCourseContent = sumCourseContents[j] / stdMarks.GetLength(0);
//             Console.WriteLine($"{courseContent[j]} average: {avgCourseContent}");
//         }

//         Console.WriteLine("Final Marks for each student:");
//         for (int i = 0; i < stdMarks.GetLength(0); i++)
//         {
//             double finalMark = 0;
//             for (int j = 0; j < stdMarks.GetLength(1); j++)
//             {
//                 finalMark += stdMarks[i, j] * courseWeights[j];
//             }
//             Console.WriteLine($"ID: {stdID[i]}, Name: {stdNames[i]}, Final Mark: {finalMark}");
//         }
//     }
// }
