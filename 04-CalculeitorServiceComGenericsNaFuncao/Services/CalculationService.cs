using System;
using System.Collections.Generic;

namespace _04_CalculeitorServiceComGenericsNaFuncao.Services
{
    class CalculationService
    {
        //declaramos tipo T Nome método tb Max<T> List recebe tipo T pra usar IComparable (where T : IComparable )
        public T Max<T>(List<T> list) where T :IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }
            //Aqui pegamos Lista do tipo product no primeiro elemento
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {   //fizemos for com tamanho da lista
                //list[0]=10 max 10 = 0 //CompareTo retorno comparação int
                //list[1]=11 max 10 = 1
                //list[2]=12 max 11 = 1
                //list[3]=10 max 12 = -1
                //Comparando String
                //list[1]=beto max andre = 1 //CompareTo retorno comparação int
                //list[1]=cesaer max beto = 1
                //list[2]=12 max 11 = 1
                //list[3]=10 max 12 = -1
                int a = list[i].CompareTo(max);
                if (a > 0)
                { 
                    max = list[i];
                }
            }
            return max;
        }
    }
}
