using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace World_Skills
{
    // Класс для работы с подключением к бд
    class Connecting 
    {
        // Строка запроса на подключение к бд
        private string conect = "Data Source=DESKTOP-AJQ1RHN\\WORLDSKILLS;Initial Catalog=MySQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string answers = "";

        public string connection(string command,bool answer, string control__text)
        {

            // Создание переменной для подключения к бд
            SqlConnection sql;

            // Подключение к бд
            using (sql = new SqlConnection(conect))
            {
                // Открытие подключения
                sql.Open();
                
                // Создание переменной для SQL команды
                SqlCommand com;

                // Подключение команды
                using (com = new SqlCommand(command, sql))
                {

                    // Проверка на выдачу ответа
                    if(answer)
                    {   
                        
                        /* 
                           /////////////////////////////////////////////                        
                                    Запрос с ожиданием ответа
                           ////////////////////////////////////////////
                         */
                       

                        // Получение ответа от сервера
                        SqlDataReader Read = com.ExecuteReader();

                        // Цикл считывания данных
                        while (Read.Read())
                        {

                            // Выборка считывания данных по контрольному тексту 
                            switch(control__text)
                            {

                                // Получение id
                                case "get_id": {

                                        // Отсылание id из функции
                                        return Read["id"].ToString();

                                        break;}

                                // Авторизация  пользователя
                                case "auth":
                                    {

                                        // Вывод типа пользователя и его коментарий
                                        return Read["Type"].ToString()+" "+Read["Comment"].ToString();

                                        break;
                                    }
                                case "Get__Tissue":
                                    {
                                        // Получение комбобокса Тканей
                                        answers += Read["Артикул"].ToString() + " " + Read["Название"].ToString()+"|";

                                        break;
                                    }
                                case "Get__FUR":
                                    {
                                        // Получение комбобокса Фурнитуры
                                        answers += Read["Артикул"].ToString() + " " + Read["Наименование"].ToString() + "|";

                                        break;
                                    }
                            }

                        }

                    }
                    else
                    {

                        /* 
                          /////////////////////////////////////////////                        
                                      Запрос без ответа
                          ////////////////////////////////////////////
                        */
                        com.ExecuteNonQuery();

                        return "";
                    }
                    // Проверка на получение для групбокса
                    if (control__text == "Get__Tissue" || control__text == "Get__FUR")

                        // возращаем строку
                        return answers;
                    // Выводим Еrror
                    return "Error404";
                }

                return "Error400";
            }
            return "Error500";
        }
    }
}
