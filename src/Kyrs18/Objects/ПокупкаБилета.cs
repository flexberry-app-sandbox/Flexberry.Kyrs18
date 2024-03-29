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
    /// Покупка билета.
    /// </summary>
    // *** Start programmer edit section *** (ПокупкаБилета CustomAttributes)

    // *** End programmer edit section *** (ПокупкаБилета CustomAttributes)
    [AutoAltered()]
    [Caption("Покупка билета")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПокупкаБилетаE", new string[] {
            "ДатаПокупки as \'Дата покупки\'",
            "ВремяПокупки as \'Время покупки\'",
            "Покупатель as \'ФИО\'",
            "Покупатель.ДатРожд as \'Дата рождения\'",
            "Покупатель.СерияПаспорта as \'Серия паспорта\'",
            "Покупатель.НомерПаспорта as \'Номер паспорта\'",
            "Покупатель.БанкСчет as \'Банковский счет\'",
            "Покупатель.ЭлПочта as \'Электронная почта\'",
            "ВарПолучБилет as \'Вариант получения билета\'"})]
    [AssociatedDetailViewAttribute("ПокупкаБилетаE", "Информация", "ИнформацияE", false, "", "Информация", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ПокупкаБилетаE", "Покупатель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [View("ПокупкаБилетаL", new string[] {
            "ДатаПокупки as \'Дата покупки\'",
            "ВремяПокупки as \'Время покупки\'",
            "Покупатель as \'ФИО\'",
            "Покупатель.ДатРожд as \'Дата рождения\'",
            "Покупатель.СерияПаспорта as \'Серия паспорта\'",
            "Покупатель.НомерПаспорта as \'Номер паспорта\'",
            "Покупатель.БанкСчет as \'Банковский счет\'",
            "Покупатель.ЭлПочта as \'Электронная почта\'",
            "ВарПолучБилет as \'Вариант получения билета\'"})]
    [MasterViewDefineAttribute("ПокупкаБилетаL", "Покупатель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    public class ПокупкаБилета : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Kyrs18.Вариант fВарПолучБилет;
        
        private string fВремяПокупки;
        
        private System.DateTime fДатаПокупки = System.DateTime.Now;
        
        private IIS.Kyrs18.Покупатель fПокупатель;
        
        private IIS.Kyrs18.БилетКасса fБилетКасса;
        
        private IIS.Kyrs18.DetailArrayOfИнформация fИнформация;
        
        // *** Start programmer edit section *** (ПокупкаБилета CustomMembers)

        // *** End programmer edit section *** (ПокупкаБилета CustomMembers)

        
        /// <summary>
        /// ВарПолучБилет.
        /// </summary>
        // *** Start programmer edit section *** (ПокупкаБилета.ВарПолучБилет CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.ВарПолучБилет CustomAttributes)
        public virtual IIS.Kyrs18.Вариант ВарПолучБилет
        {
            get
            {
                // *** Start programmer edit section *** (ПокупкаБилета.ВарПолучБилет Get start)

                // *** End programmer edit section *** (ПокупкаБилета.ВарПолучБилет Get start)
                IIS.Kyrs18.Вариант result = this.fВарПолучБилет;
                // *** Start programmer edit section *** (ПокупкаБилета.ВарПолучБилет Get end)

                // *** End programmer edit section *** (ПокупкаБилета.ВарПолучБилет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПокупкаБилета.ВарПолучБилет Set start)

                // *** End programmer edit section *** (ПокупкаБилета.ВарПолучБилет Set start)
                this.fВарПолучБилет = value;
                // *** Start programmer edit section *** (ПокупкаБилета.ВарПолучБилет Set end)

                // *** End programmer edit section *** (ПокупкаБилета.ВарПолучБилет Set end)
            }
        }
        
        /// <summary>
        /// ВремяПокупки.
        /// </summary>
        // *** Start programmer edit section *** (ПокупкаБилета.ВремяПокупки CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.ВремяПокупки CustomAttributes)
        [StrLen(255)]
        public virtual string ВремяПокупки
        {
            get
            {
                // *** Start programmer edit section *** (ПокупкаБилета.ВремяПокупки Get start)

                // *** End programmer edit section *** (ПокупкаБилета.ВремяПокупки Get start)
                string result = this.fВремяПокупки;
                // *** Start programmer edit section *** (ПокупкаБилета.ВремяПокупки Get end)

                // *** End programmer edit section *** (ПокупкаБилета.ВремяПокупки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПокупкаБилета.ВремяПокупки Set start)

                // *** End programmer edit section *** (ПокупкаБилета.ВремяПокупки Set start)
                this.fВремяПокупки = value;
                // *** Start programmer edit section *** (ПокупкаБилета.ВремяПокупки Set end)

                // *** End programmer edit section *** (ПокупкаБилета.ВремяПокупки Set end)
            }
        }
        
        /// <summary>
        /// ДатаПокупки.
        /// </summary>
        // *** Start programmer edit section *** (ПокупкаБилета.ДатаПокупки CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.ДатаПокупки CustomAttributes)
        public virtual System.DateTime ДатаПокупки
        {
            get
            {
                // *** Start programmer edit section *** (ПокупкаБилета.ДатаПокупки Get start)

                // *** End programmer edit section *** (ПокупкаБилета.ДатаПокупки Get start)
                System.DateTime result = this.fДатаПокупки;
                // *** Start programmer edit section *** (ПокупкаБилета.ДатаПокупки Get end)

                // *** End programmer edit section *** (ПокупкаБилета.ДатаПокупки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПокупкаБилета.ДатаПокупки Set start)

                // *** End programmer edit section *** (ПокупкаБилета.ДатаПокупки Set start)
                this.fДатаПокупки = value;
                // *** Start programmer edit section *** (ПокупкаБилета.ДатаПокупки Set end)

                // *** End programmer edit section *** (ПокупкаБилета.ДатаПокупки Set end)
            }
        }
        
        /// <summary>
        /// Покупка билета.
        /// </summary>
        // *** Start programmer edit section *** (ПокупкаБилета.БилетКасса CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.БилетКасса CustomAttributes)
        [PropertyStorage(new string[] {
                "БилетКасса"})]
        [NotNull()]
        public virtual IIS.Kyrs18.БилетКасса БилетКасса
        {
            get
            {
                // *** Start programmer edit section *** (ПокупкаБилета.БилетКасса Get start)

                // *** End programmer edit section *** (ПокупкаБилета.БилетКасса Get start)
                IIS.Kyrs18.БилетКасса result = this.fБилетКасса;
                // *** Start programmer edit section *** (ПокупкаБилета.БилетКасса Get end)

                // *** End programmer edit section *** (ПокупкаБилета.БилетКасса Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПокупкаБилета.БилетКасса Set start)

                // *** End programmer edit section *** (ПокупкаБилета.БилетКасса Set start)
                this.fБилетКасса = value;
                // *** Start programmer edit section *** (ПокупкаБилета.БилетКасса Set end)

                // *** End programmer edit section *** (ПокупкаБилета.БилетКасса Set end)
            }
        }
        
        /// <summary>
        /// Покупка билета.
        /// </summary>
        // *** Start programmer edit section *** (ПокупкаБилета.Покупатель CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.Покупатель CustomAttributes)
        [PropertyStorage(new string[] {
                "Покупатель"})]
        [NotNull()]
        public virtual IIS.Kyrs18.Покупатель Покупатель
        {
            get
            {
                // *** Start programmer edit section *** (ПокупкаБилета.Покупатель Get start)

                // *** End programmer edit section *** (ПокупкаБилета.Покупатель Get start)
                IIS.Kyrs18.Покупатель result = this.fПокупатель;
                // *** Start programmer edit section *** (ПокупкаБилета.Покупатель Get end)

                // *** End programmer edit section *** (ПокупкаБилета.Покупатель Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПокупкаБилета.Покупатель Set start)

                // *** End programmer edit section *** (ПокупкаБилета.Покупатель Set start)
                this.fПокупатель = value;
                // *** Start programmer edit section *** (ПокупкаБилета.Покупатель Set end)

                // *** End programmer edit section *** (ПокупкаБилета.Покупатель Set end)
            }
        }
        
        /// <summary>
        /// Покупка билета.
        /// </summary>
        // *** Start programmer edit section *** (ПокупкаБилета.Информация CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.Информация CustomAttributes)
        public virtual IIS.Kyrs18.DetailArrayOfИнформация Информация
        {
            get
            {
                // *** Start programmer edit section *** (ПокупкаБилета.Информация Get start)

                // *** End programmer edit section *** (ПокупкаБилета.Информация Get start)
                if ((this.fИнформация == null))
                {
                    this.fИнформация = new IIS.Kyrs18.DetailArrayOfИнформация(this);
                }
                IIS.Kyrs18.DetailArrayOfИнформация result = this.fИнформация;
                // *** Start programmer edit section *** (ПокупкаБилета.Информация Get end)

                // *** End programmer edit section *** (ПокупкаБилета.Информация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПокупкаБилета.Информация Set start)

                // *** End programmer edit section *** (ПокупкаБилета.Информация Set start)
                this.fИнформация = value;
                // *** Start programmer edit section *** (ПокупкаБилета.Информация Set end)

                // *** End programmer edit section *** (ПокупкаБилета.Информация Set end)
            }
        }
        
        // *** Start programmer edit section *** (ПокупкаБилета.Распечатать CustomAttributes)

        // *** End programmer edit section *** (ПокупкаБилета.Распечатать CustomAttributes)
        [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
        public virtual void Распечатать()
        {
            // *** Start programmer edit section *** (ПокупкаБилета.Распечатать method implementation)
            return;
            // *** End programmer edit section *** (ПокупкаБилета.Распечатать method implementation)
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПокупкаБилетаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПокупкаБилетаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПокупкаБилетаE", typeof(IIS.Kyrs18.ПокупкаБилета));
                }
            }
            
            /// <summary>
            /// "ПокупкаБилетаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПокупкаБилетаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПокупкаБилетаL", typeof(IIS.Kyrs18.ПокупкаБилета));
                }
            }
        }
    }
}
