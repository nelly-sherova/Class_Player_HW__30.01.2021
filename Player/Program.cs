using System;

namespace Player
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Видео воспроизводится!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Видео поставлено на паузу!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Stop()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Stop");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Record()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Видео записывается!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вас приветствует класс Player!");
            int c = 0;
            bool b = true;
            char Doo;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Для записи видео нажмите 1\nДля просмотра видео нажмите 2,\nДля выхода из Проигрывателя нажмите 0");
            Console.ForegroundColor = ConsoleColor.White;
            c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1: 
                Doo = '1';
                while (b == true)
                {
                    switch(Doo)
                    {
                        case '1': 
                            player.Record();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Следующие действия: \n 2--> Пауза\n3-->Стоп, 0-->Выход");
                            Console.ForegroundColor = ConsoleColor.White;
                            Doo = Convert.ToChar(Console.ReadLine());
                        break;
                        case '2':
                            player.Pause();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Следующие действия: \n 1--> Возобновть запись\n3-->Стоп, 0-->Выход");
                            Console.ForegroundColor = ConsoleColor.White;
                            Doo = Convert.ToChar(Console.ReadLine());
                        break;
                        case '3':
                            player.Stop();
                            b = false;
                        break;
                        case '0' : 
                            b = false;
                        break;
                        default: 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели неправильную команду!");
                            Console.ForegroundColor = ConsoleColor.White;
                            b = false;
                        break;
                                
                    }
                }
                break;
                case 2 : 
                    Doo = '1';
                    while (b == true)
                    {
                        switch(Doo)
                        {
                            case '1': 
                                player.Play();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Следующие действия: \n 2--> Пауза\n3-->Стоп, 0-->Выход");
                                Console.ForegroundColor = ConsoleColor.White;
                                Doo = Convert.ToChar(Console.ReadLine());
                            break;
                            case '2':
                                player.Pause();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Следующие действия: \n 1--> Возобновть просмотр\n3-->Стоп, 0-->Выход");
                                Console.ForegroundColor = ConsoleColor.White;
                                Doo = Convert.ToChar(Console.ReadLine());
                            break;
                            case '3':
                                player.Stop();
                                b = false;
                            break;
                            case '0' : 
                                b = false;
                            break;
                            default: 
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Вы ввели неправильную команду!");
                                Console.ForegroundColor = ConsoleColor.White;
                                b = false;
                            break;   
                        }
                    }
                break;
                case 0 :
                    Console.WriteLine("Вы вышли из проигрывателя!");
                break;
                default :
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильная команда! Будет осуществлен выход из плеера!");
                    Console.ForegroundColor = ConsoleColor.White;
                break;     
            }
        }
    }
}
