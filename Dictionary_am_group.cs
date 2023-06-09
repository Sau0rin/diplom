﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Dictionary_am_group
    {
        public string dictionary (string name)
        {
            string[][] all = new string[2][]; 
            
            
            all[0] =  new string [] { "комплекты инструмента для телекоммуникационного оборудования и линейно-кабельных работ",
                "приспособления и оснастка для эксплуатационных работ в связи",
                "аппаратура / оборудование для исследований в скважинах",
                "оборудование для подготовительных работ при ремонте и обслуживании эксплуатационных скважин","инструмент строительно-монтажный ручной"
            ,"инструмент строительно-монтажный ручной","насосы конденсатные","насосы питательные" ,"насосы песковые" ,"насосы грунтовые" ,"насосы шламовые" ,"Компрессоры",
                "конвейеры ленточные","конвейеры скребковые","конвейеры передвижные","оборудование для производства и монтажа вентиляционных и санитарно-технических заготовок и изделий",
                "нструмент и приспособления для производства и монтажа вентиляционных и санитарно-технических заготовок и изделий",
                "средства крепления для производства и монтажа вентиляционных и санитарно-технических заготовок и изделий",
                "механизмы для электромонтажных и пусконаладочных работ по оборудованию промышленных предприятий",
                "инструменты для электромонтажных и пусконаладочных работ по оборудованию промышленных предприятий",
                "приспособления для электромонтажных и пусконаладочных работ по оборудованию промышленных предприятий",
                "приборы и устройства для электромонтажных и пусконаладочных работ по оборудованию промышленных предприятий",
                "валки стальные, прокатные для сортопрокатных станов","валки стальные, прокатные для полосовых станов",
                "валки стальные, прокатные для листопрокатных  станов",
                "инструмент медицинский","инструмент для протезной промышленности","Машины для выемки грунта: электрические ",
                "Машины для выемки грунта:пневматические",
                "инструмент для металлообрабатывающих станков",
                "инструмент для деревообрабатывающих станков","дизели и дизель-генераторы с цилиндром диаметром свыше 160 мм",
                "дизель и дизель-генераторы буровые",
                "инструмент малой механизации лесохозяйственного применения, лесоустроительного и таксационного назначения",
                "инвентарь малой механизации лесохозяйственного применения, лесоустроительного и таксационного назначения",
                "средства малой механизации лесохозяйственного применения, лесоустроительного и таксационного назначения",
                "инструмент алмазный","инструмент абразивный",
                "молотки отбойные","крепь проходческая механизированная","двигатели забойные","инструмент породоразрушающий (для нефтяных скважин) (турбобуры, буры, турбодолота, долота, отклонители, электробуры, расширители, калибраторы и прочие)",
                "машины для зарядки и забойки взрывных скважин",
                "оборудование для зарядки и забойки взрывных скважин",
                "замки концы к бурильным трубам","соединительные концы к бурильным трубам",
                "элементы компоновки низа бурильной колонны","замки буровые для электробура",
                "замки буровые специальные",
                "инструмент ловильный для ликвидации аварий при бурении",
                "инструмент и приспособления для зарезки вторых стволов",
                "инструмент буровой (кроме породоразрушающего)",
                "инструмент для свинчивания - развинчивания и удержания на весу насосно-компрессорных труб и штанг при ремонте эксплуатационных скважин",
                "инструмент ловильный для эксплуатационных скважин",
                "инструмент для бурения геолого-разведочных скважин",
                "инструмент для нефтепромыслового и геолого-разведочного оборудования"};
            
            
            
            
            all[1] = new string[] { "Форма литейная", "опоки для литья металлов", "поддоны литейные", "модели литейные",
                "оборудование для контроля технологических процессов",
                "оборудование буровое нефтепромысловое",
                "оборудование буровое геолого-разведочное",
                "насосы артезианские", "насосы погружные",
                "подъемники мачтовые строительные", "грейферы", "приспособления и устройства грузозахватные", "оснащение монтажное",
                "приспособления навесные для уплотнения грунтов", " конвейеры ленточные передвижные с прорезиненной лентой",
                "валки опорные", "машины для заготовки грубых кормов",
                "питатели ленточные стационарные",
                "персональный компьютер", "печатающие устройства", "сервер", "сетевое оборудование локальных вычислительных сетей",
                "систем хранения данных", "модем для локальных сетей", "модем для магистральных сетей",
                "гидроциклоны однокорпусные", "батареи гидроциклонов", "питатели (без лабораторных)", "Косилки (включая устройства режущие для установки на тракторе)",
                "плющилки тракторные", "волокуши тракторные",
                "грабли конные", "грабли тракторные", "ворошилки", "установки искусственного досушивания сена",
                "машины для заготовки грубых кормов прочие", "Оборудование для приготовления кормов для животных",
                "оборудование специальное технологическое для животноводства и кормопроизводства",
                "оборудование немеханизированное", "ручная аппаратура для кислородной резки металлов", "сменные машинные резаки",
                "Подъемники и конвейеры непрерывного действия для подземных работ",
                "Прессы для соломы или сена (включая пресс-подборщики)", "Ковши для металлургического производства",
                "машины бурильные","машины пневмоударники","оборудование навесное бурильное",
                "машины и оборудование для зарядки и забойки взрывных скважин", "оборудование горноспасательное",
                "аппаратура шахтной автоматизации", "аппаратура шахтной сигнализации ", "аппаратура шахтной связи",
                "бункеры для сухих и влажных кормов" ,"Машины для измельчения и нарезания",
                "машины и инструменты для работы с отдельными элементами верхнего строения пути",
                "технологическая оснастка для протезной промышленности","подъемники грузопассажирские","Сооружения для занятий спортом и отдыха","земляника"}; ;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < all[i].Length; j++)
                {
                    if (all[i][j] == name)                
                        return (i + 1).ToString();
                }
            }
            return "";
        }
        public string norma_amor (string key)
        {
            try
            {
                var norma = new Dictionary<string, string>()
                {
                    ["1"] = "14,3",
                    ["2"] = "8,8",
                    ["3"] = "5,6",
                    ["4"] = "3,8",
                    ["5"] = "2,7",
                    ["6"] = "1,8",
                    ["7"] = "1,3",
                    ["8"] = "1,0",
                    ["9"] = "0,8",
                    ["10"] = "0,7",
                };
                return norma[key];
            }
            catch
            {
                MessageBox.Show("Несуществующая группа");
                return "";
            }

            
        }
    }
}
