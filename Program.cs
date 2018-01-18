//BenOluwa
//CWEB2010
//DUE: 1/18/18
//LAB 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questionNum = {"Question 1","Question 2", "Question 3", "Question 4", "Question 5",
                                    "Question 6", "Question 7", "Question 8", "Question 9", "Question 10",
                                    "Question 11", "Question 12", "Question 13", "Question 14", "Question 15",
                                    "Question 16", "Question 17", "Question 18", "Question 19", "Question 20"};
            string[] userAnswer = new string[20];
            string userResponse;
            int Pass_Score = 15;
            int x;
            int total = 20;
            int[] questionHolder = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int correct;
            int incorrect;
            int cont;
            int EXIT = 0;
            int count;


            string[] answerKey = { "B", "D", "A", "A", "C",
                                    "A", "B", "A", "C", "D",
                                    "B", "C", "D", "A", "D",
                                    "C", "C", "B", "D", "A"};


            WriteLine("This is a Minnesota Driver's license exam. This Exam contains 20 questions and will give immediate feedback on results");
            WriteLine("Press 1 to start the exam");
            cont = Convert.ToInt16(ReadLine());
                
            Clear();
            while (cont != EXIT)
            {
                correct = 0;
                incorrect = 0;
                for (x = 0; x <= 19; x++)
                {
                    WriteLine("What is your answer to question {0}", x+1);
                    incorrect = 0;
                    userResponse = ReadLine();
                    userResponse = userResponse.ToUpper();//turns user input to uppercase
                    while (userResponse !=  "A" && userResponse != "B" && userResponse != "C" && userResponse != "D")
                    {
                        WriteLine("Invalid input, please enter a value that is between A - D.");
                        userResponse = ReadLine();
                        userResponse = userResponse.ToUpper();
                    }
                    userAnswer[x] = userResponse;
                    if (userAnswer[x] == answerKey[x])
                    {
                        correct = correct + 1;
                    }
                    else
                    {
                        incorrect = incorrect + 1;
                        
                    }
                    questionHolder[x] = questionHolder[x] + incorrect;
                }//end of for loop
                count = total - correct;

                if (correct >= Pass_Score)
                {
                    WriteLine("You passed with a score of {0} out of {1}", correct, total);
                }
                else
                {
                    WriteLine("Sorry, you did not pass the exam. You missed a total of {0} out of {1}. Please retry.",count,total);
                }//end of if/else statments for test pass
                WriteLine("Here are the questions you missed");
                for (x = 0; x < questionHolder.Length; x++)
                {
                    if (questionHolder[x] == 1)
                    {
                        WriteLine(questionNum[x]);
                    }
                    
                }//end for loop

                WriteLine("To enter another test, please press 1. To exit please press 0");
                cont = Convert.ToInt16(ReadLine());
            }
            WriteLine("Thanks for taking the exam");
            ReadLine();
        }
        //END OF PROGRAM
    }
}
