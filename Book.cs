﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid grade {nameof(grade)}");
            }
                
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index = 0; index < grades.Count; index++)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;
            
            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 98.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}
