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
    /// Оператор.
    /// </summary>
    // *** Start programmer edit section *** (Оператор CustomAttributes)

    // *** End programmer edit section *** (Оператор CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОператорE", new string[] {
            "ID as \'ID\'",
            "ФИО as \'ФИО\'",
            "НомерПаспорта as \'Номер паспорта\'",
            "СерияПаспорта as \'Серия паспорта\'"})]
    [View("ОператорL", new string[] {
            "ID as \'ID\'",
            "ФИО as \'ФИО\'",
            "НомерПаспорта as \'Номер паспорта\'",
            "СерияПаспорта as \'Серия паспорта\'"})]
    public class Оператор : ICSSoft.STORMNET.DataObject
    {
        
        private string fФИО;
        
        private int fНомерПаспорта;
        
        private int fID;
        
        private int fСерияПаспорта;
        
        // *** Start programmer edit section *** (Оператор CustomMembers)

        // *** End programmer edit section *** (Оператор CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Оператор.ID CustomAttributes)

        // *** End programmer edit section *** (Оператор.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Оператор.ID Get start)

                // *** End programmer edit section *** (Оператор.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Оператор.ID Get end)

                // *** End programmer edit section *** (Оператор.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оператор.ID Set start)

                // *** End programmer edit section *** (Оператор.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Оператор.ID Set end)

                // *** End programmer edit section *** (Оператор.ID Set end)
            }
        }
        
        /// <summary>
        /// НомерПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (Оператор.НомерПаспорта CustomAttributes)

        // *** End programmer edit section *** (Оператор.НомерПаспорта CustomAttributes)
        public virtual int НомерПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (Оператор.НомерПаспорта Get start)

                // *** End programmer edit section *** (Оператор.НомерПаспорта Get start)
                int result = this.fНомерПаспорта;
                // *** Start programmer edit section *** (Оператор.НомерПаспорта Get end)

                // *** End programmer edit section *** (Оператор.НомерПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оператор.НомерПаспорта Set start)

                // *** End programmer edit section *** (Оператор.НомерПаспорта Set start)
                this.fНомерПаспорта = value;
                // *** Start programmer edit section *** (Оператор.НомерПаспорта Set end)

                // *** End programmer edit section *** (Оператор.НомерПаспорта Set end)
            }
        }
        
        /// <summary>
        /// СерияПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (Оператор.СерияПаспорта CustomAttributes)

        // *** End programmer edit section *** (Оператор.СерияПаспорта CustomAttributes)
        public virtual int СерияПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (Оператор.СерияПаспорта Get start)

                // *** End programmer edit section *** (Оператор.СерияПаспорта Get start)
                int result = this.fСерияПаспорта;
                // *** Start programmer edit section *** (Оператор.СерияПаспорта Get end)

                // *** End programmer edit section *** (Оператор.СерияПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оператор.СерияПаспорта Set start)

                // *** End programmer edit section *** (Оператор.СерияПаспорта Set start)
                this.fСерияПаспорта = value;
                // *** Start programmer edit section *** (Оператор.СерияПаспорта Set end)

                // *** End programmer edit section *** (Оператор.СерияПаспорта Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Оператор.ФИО CustomAttributes)

        // *** End programmer edit section *** (Оператор.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Оператор.ФИО Get start)

                // *** End programmer edit section *** (Оператор.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Оператор.ФИО Get end)

                // *** End programmer edit section *** (Оператор.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оператор.ФИО Set start)

                // *** End programmer edit section *** (Оператор.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Оператор.ФИО Set end)

                // *** End programmer edit section *** (Оператор.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОператорE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОператорE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОператорE", typeof(IIS.Kyrs18.Оператор));
                }
            }
            
            /// <summary>
            /// "ОператорL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОператорL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОператорL", typeof(IIS.Kyrs18.Оператор));
                }
            }
        }
    }
}
