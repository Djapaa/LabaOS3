﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenProc
{
    public class ДочернийПроцесс

    {
        public static void Main()

        {
            try

            {

                // Получаем текущий процесс

                Process p = Process.GetCurrentProcess();

                // Получаем блок окружения текущего процесса
       
                var env = p.StartInfo.EnvironmentVariables;

                double xmax = 11;
                double xmin = 1;
                double y = 0;


              

                foreach (string key in env.Keys)

                {
                    if ((key == "Выбранные функции")&&(env[key] == "1 и 2"))
                    {
                        for (double x = xmin; x < xmax; x++)
                        {
                            y = Math.Sin(x) * Math.Cos(x);

                            Console.WriteLine("Sin({0})*Сos({0}) = {1}", x, y);
                           

                        }
                    }
                        

                }

                
               

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }
    }


}
