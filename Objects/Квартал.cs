﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.SmartMogila
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Квартал.
    /// </summary>
    //  *** Start programmer edit section *** (Квартал CustomAttributes)

    //  *** End programmer edit section *** (Квартал CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КварталE", new string[] {
            "Номер as \'Номер\'",
            "Площадь as \'Площадь\'",
            "Кладбище as \'Кладбище\'",
            "Кладбище.Название as \'Название\'"})]
    [View("КварталL", new string[] {
            "Номер as \'Номер\'",
            "Площадь as \'Площадь\'",
            "Кладбище.Название as \'Название\'"})]
    public class Квартал : ICSSoft.STORMNET.DataObject
    {
        
        private string fНомер;
        
        private double fПлощадь;
        
        private IIS.SmartMogila.Кладбище fКладбище;
        
        //  *** Start programmer edit section *** (Квартал CustomMembers)

        //  *** End programmer edit section *** (Квартал CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        //  *** Start programmer edit section *** (Квартал.Номер CustomAttributes)

        //  *** End programmer edit section *** (Квартал.Номер CustomAttributes)
        [StrLen(255)]
        public virtual string Номер
        {
            get
            {
                //  *** Start programmer edit section *** (Квартал.Номер Get start)

                //  *** End programmer edit section *** (Квартал.Номер Get start)
                string result = this.fНомер;
                //  *** Start programmer edit section *** (Квартал.Номер Get end)

                //  *** End programmer edit section *** (Квартал.Номер Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Квартал.Номер Set start)

                //  *** End programmer edit section *** (Квартал.Номер Set start)
                this.fНомер = value;
                //  *** Start programmer edit section *** (Квартал.Номер Set end)

                //  *** End programmer edit section *** (Квартал.Номер Set end)
            }
        }
        
        /// <summary>
        /// Площадь.
        /// </summary>
        //  *** Start programmer edit section *** (Квартал.Площадь CustomAttributes)

        //  *** End programmer edit section *** (Квартал.Площадь CustomAttributes)
        public virtual double Площадь
        {
            get
            {
                //  *** Start programmer edit section *** (Квартал.Площадь Get start)

                //  *** End programmer edit section *** (Квартал.Площадь Get start)
                double result = this.fПлощадь;
                //  *** Start programmer edit section *** (Квартал.Площадь Get end)

                //  *** End programmer edit section *** (Квартал.Площадь Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Квартал.Площадь Set start)

                //  *** End programmer edit section *** (Квартал.Площадь Set start)
                this.fПлощадь = value;
                //  *** Start programmer edit section *** (Квартал.Площадь Set end)

                //  *** End programmer edit section *** (Квартал.Площадь Set end)
            }
        }
        
        /// <summary>
        /// Квартал.
        /// </summary>
        //  *** Start programmer edit section *** (Квартал.Кладбище CustomAttributes)

        //  *** End programmer edit section *** (Квартал.Кладбище CustomAttributes)
        [NotNull()]
        public virtual IIS.SmartMogila.Кладбище Кладбище
        {
            get
            {
                //  *** Start programmer edit section *** (Квартал.Кладбище Get start)

                //  *** End programmer edit section *** (Квартал.Кладбище Get start)
                IIS.SmartMogila.Кладбище result = this.fКладбище;
                //  *** Start programmer edit section *** (Квартал.Кладбище Get end)

                //  *** End programmer edit section *** (Квартал.Кладбище Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Квартал.Кладбище Set start)

                //  *** End programmer edit section *** (Квартал.Кладбище Set start)
                this.fКладбище = value;
                //  *** Start programmer edit section *** (Квартал.Кладбище Set end)

                //  *** End programmer edit section *** (Квартал.Кладбище Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КварталE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КварталE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КварталE", typeof(IIS.SmartMogila.Квартал));
                }
            }
            
            /// <summary>
            /// "КварталL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КварталL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КварталL", typeof(IIS.SmartMogila.Квартал));
                }
            }
        }
    }
}
