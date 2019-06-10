﻿using ShopAccessApp.BackEnd.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShopAccessApp.BackEnd.Logics
{
    static public class RegistrationKeyGeneration
    {
        static public string GetRandomKey()
        {
            var chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[20];
            var random = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    stringChars[i*5 + j] = chars[random.Next(chars.Length)];
                }
            }
            stringChars[4] = '-';
            stringChars[9] = '-';
            stringChars[13] = '-';

            return new String(stringChars);
        }

        static public void SaveToDatabase(string key, UserType userType)
        {
            RegistrationAccessor.CreateNew(new Registration()
            {
                access_level = (short)userType,
                activation_code = key
            });
        }
    }
}
