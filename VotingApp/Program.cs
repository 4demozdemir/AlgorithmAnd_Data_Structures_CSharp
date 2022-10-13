using System;
using System.Collections.Generic;

namespace VotingApp
{
    internal class Program
    {
        //Voting Uygulaması
        //    Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir.
        //    Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir.
        //    Oylama sırasında öncelikle kullanıcının username'i istenmelidir.
        //    Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir.
        //    Kategoriler isteğe bağlı olarak belirlenebilir.
        //    Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri
        //    Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.
        //    Kullanılması gereken teknikler:
        //    Kategoriler pre-defined kullanılabilir.


        static void Main(string[] args)
        {
            
            Console.Write("Kullanıcı adı giriniz : ");
            string inputs = Console.ReadLine();
            
            var username = new List<string>();
            username.Add("ADEM");
            username.Add("ALİ");
          

            
            if (username.Contains(inputs.ToUpper()))
            {
                //Choice();
            }
            else
            {

                Console.Write("Kayıt için  kullanıcı adı giriniz : ");
                inputs = Console.ReadLine();
                Console.WriteLine("username giriniz:");
                username.Add(Console.ReadLine());    
                
            }


        }

        private static void Choice()
        {
            string[] categories = { "SPORT", "TECH STACK", "HİSTORY", "POLITICS", "AGENDA", "LIFE" };

            Console.WriteLine("Hello Players! \n ---------------------------------");
            for (int i = 0; i < categories.Length; i++)
            {
                Console.Write(i + 1 + categories[i] + "\n");
            }
            Console.Write("İşlem yapmak istediğiniz categoriyi seçiniz :");
            int choice = Convert.ToInt32(Console.ReadLine());
        }


    }
}
