﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kyrs18
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Информация.
    /// </summary>
    // *** Start programmer edit section *** (Информация CustomAttributes)

    // *** End programmer edit section *** (Информация CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ИнформацияE", new string[] {
            "ДатаПоезд as \'Дата поездки\'",
            "Место as \'Место\'",
            "Маршрут as \'Номер маршрута\'",
            "Маршрут.КонечПункт as \'Конечный пункт\'",
            "Маршрут.ВремяОтправ as \'Время отправления\'",
            "Маршрут.ВремяПрибыт as \'Время прибытия\'",
            "Маршрут.Стоимость as \'Стоимость\'",
            "Маршрут.Перевозчик as \'Перевозчик\'"})]
    [MasterViewDefineAttribute("ИнформацияE", "Маршрут", ICSSoft.STORMNET.LookupTypeEnum.Combo, "", "НомерМаршрута")]
    public class Информация : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаПоезд;
        
        private int fМесто;
        
        private IIS.Kyrs18.Маршрут fМаршрут;
        
        private IIS.Kyrs18.ПокупкаБилета fПокупкаБилета;
        
        // *** Start programmer edit section *** (Информация CustomMembers)

        // *** End programmer edit section *** (Информация CustomMembers)

        
        /// <summary>
        /// ДатаПоезд.
        /// </summary>
        // *** Start programmer edit section *** (Информация.ДатаПоезд CustomAttributes)

        // *** End programmer edit section *** (Информация.ДатаПоезд CustomAttributes)
        public virtual System.DateTime ДатаПоезд
        {
            get
            {
                // *** Start programmer edit section *** (Информация.ДатаПоезд Get start)

                // *** End programmer edit section *** (Информация.ДатаПоезд Get start)
                System.DateTime result = this.fДатаПоезд;
                // *** Start programmer edit section *** (Информация.ДатаПоезд Get end)

                // *** End programmer edit section *** (Информация.ДатаПоезд Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Информация.ДатаПоезд Set start)

                // *** End programmer edit section *** (Информация.ДатаПоезд Set start)
                this.fДатаПоезд = value;
                // *** Start programmer edit section *** (Информация.ДатаПоезд Set end)

                // *** End programmer edit section *** (Информация.ДатаПоезд Set end)
            }
        }
        
        /// <summary>
        /// Место.
        /// </summary>
        // *** Start programmer edit section *** (Информация.Место CustomAttributes)

        // *** End programmer edit section *** (Информация.Место CustomAttributes)
        public virtual int Место
        {
            get
            {
                // *** Start programmer edit section *** (Информация.Место Get start)

                // *** End programmer edit section *** (Информация.Место Get start)
                int result = this.fМесто;
                // *** Start programmer edit section *** (Информация.Место Get end)

                // *** End programmer edit section *** (Информация.Место Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Информация.Место Set start)

                // *** End programmer edit section *** (Информация.Место Set start)
                this.fМесто = value;
                // *** Start programmer edit section *** (Информация.Место Set end)

                // *** End programmer edit section *** (Информация.Место Set end)
            }
        }
        
        /// <summary>
        /// Информация.
        /// </summary>
        // *** Start programmer edit section *** (Информация.Маршрут CustomAttributes)

        // *** End programmer edit section *** (Информация.Маршрут CustomAttributes)
        [PropertyStorage(new string[] {
                "Маршрут"})]
        [NotNull()]
        public virtual IIS.Kyrs18.Маршрут Маршрут
        {
            get
            {
                // *** Start programmer edit section *** (Информация.Маршрут Get start)

                // *** End programmer edit section *** (Информация.Маршрут Get start)
                IIS.Kyrs18.Маршрут result = this.fМаршрут;
                // *** Start programmer edit section *** (Информация.Маршрут Get end)

                // *** End programmer edit section *** (Информация.Маршрут Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Информация.Маршрут Set start)

                // *** End programmer edit section *** (Информация.Маршрут Set start)
                this.fМаршрут = value;
                // *** Start programmer edit section *** (Информация.Маршрут Set end)

                // *** End programmer edit section *** (Информация.Маршрут Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Kyrs18.ПокупкаБилета.
        /// </summary>
        // *** Start programmer edit section *** (Информация.ПокупкаБилета CustomAttributes)

        // *** End programmer edit section *** (Информация.ПокупкаБилета CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ПокупкаБилета"})]
        public virtual IIS.Kyrs18.ПокупкаБилета ПокупкаБилета
        {
            get
            {
                // *** Start programmer edit section *** (Информация.ПокупкаБилета Get start)

                // *** End programmer edit section *** (Информация.ПокупкаБилета Get start)
                IIS.Kyrs18.ПокупкаБилета result = this.fПокупкаБилета;
                // *** Start programmer edit section *** (Информация.ПокупкаБилета Get end)

                // *** End programmer edit section *** (Информация.ПокупкаБилета Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Информация.ПокупкаБилета Set start)

                // *** End programmer edit section *** (Информация.ПокупкаБилета Set start)
                this.fПокупкаБилета = value;
                // *** Start programmer edit section *** (Информация.ПокупкаБилета Set end)

                // *** End programmer edit section *** (Информация.ПокупкаБилета Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ИнформацияE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ИнформацияE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ИнформацияE", typeof(IIS.Kyrs18.Информация));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Информация.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfИнформация CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfИнформация CustomAttributes)
    public class DetailArrayOfИнформация : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Kyrs18.DetailArrayOfИнформация members)

        // *** End programmer edit section *** (IIS.Kyrs18.DetailArrayOfИнформация members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Информация by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Информация.
        /// </summary>
        public DetailArrayOfИнформация(IIS.Kyrs18.ПокупкаБилета fПокупкаБилета) : 
                base(typeof(Информация), ((ICSSoft.STORMNET.DataObject)(fПокупкаБилета)))
        {
        }
        
        public IIS.Kyrs18.Информация this[int index]
        {
            get
            {
                return ((IIS.Kyrs18.Информация)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Kyrs18.Информация dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
