﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {

            var reversed = "";

            for (int i = input.Length -1; i >= 0; i--)
            {
                reversed += input[i];
            }
            if (reversed == input)
            {
                return true;

            }
            else
            {
                return false;
            }
        }





    }
}
