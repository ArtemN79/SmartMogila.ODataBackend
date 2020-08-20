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
    /// Захоронение.
    /// </summary>
    //  *** Start programmer edit section *** (Захоронение CustomAttributes)

    //  *** End programmer edit section *** (Захоронение CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗахоронениеE", new string[] {
            "ИнвНомер as \'Инв номер\'",
            "ФИО as \'ФИО\'",
            "ДатаРождения as \'Дата рождения\'",
            "ДатаСмерти as \'Дата смерти\'",
            "СостояниеЗахоронения as \'Состояние захоронения\'",
            "СостояниеНадгробия as \'Состояние надгробия\'",
            "НаличиеОграды as \'Наличие ограды\'",
            "Фото as \'Фото\'",
            "КоординатыЗахоронения as \'Координаты захоронения\'",
            "Квартал as \'Квартал\'",
            "Квартал.Номер as \'Номер\'"})]
    [View("ЗахоронениеL", new string[] {
            "ИнвНомер as \'Инв номер\'",
            "ФИО as \'ФИО\'",
            "ДатаРождения as \'Дата рождения\'",
            "ДатаСмерти as \'Дата смерти\'",
            "СостояниеЗахоронения as \'Состояние захоронения\'",
            "СостояниеНадгробия as \'Состояние надгробия\'",
            "НаличиеОграды as \'Наличие ограды\'",
            "Фото as \'Фото\'",
            "КоординатыЗахоронения as \'Координаты захоронения\'",
            "Квартал.Номер as \'Номер\'"})]
    public class Захоронение : ICSSoft.STORMNET.DataObject
    {
        
        private int fИнвНомер;
        
        private string fФИО;
        
        private System.DateTime fДатаРождения;
        
        private System.DateTime fДатаСмерти;
        
        private bool fНаличиеОграды = false;
        
        private ICSSoft.STORMNET.UserDataTypes.WebFile fФото;
        
        private IIS.SmartMogila.СостояниеЗахоронения fСостояниеЗахоронения;
        
        private IIS.SmartMogila.СостояниеЗахоронения fСостояниеНадгробия;
        
        private double fКоординатыЗахоронения;
        
        private IIS.SmartMogila.Квартал fКвартал;
        
        //  *** Start programmer edit section *** (Захоронение CustomMembers)

        //  *** End programmer edit section *** (Захоронение CustomMembers)

        
        /// <summary>
        /// ИнвНомер.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.ИнвНомер CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.ИнвНомер CustomAttributes)
        public virtual int ИнвНомер
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.ИнвНомер Get start)

                //  *** End programmer edit section *** (Захоронение.ИнвНомер Get start)
                int result = this.fИнвНомер;
                //  *** Start programmer edit section *** (Захоронение.ИнвНомер Get end)

                //  *** End programmer edit section *** (Захоронение.ИнвНомер Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.ИнвНомер Set start)

                //  *** End programmer edit section *** (Захоронение.ИнвНомер Set start)
                this.fИнвНомер = value;
                //  *** Start programmer edit section *** (Захоронение.ИнвНомер Set end)

                //  *** End programmer edit section *** (Захоронение.ИнвНомер Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.ФИО CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.ФИО Get start)

                //  *** End programmer edit section *** (Захоронение.ФИО Get start)
                string result = this.fФИО;
                //  *** Start programmer edit section *** (Захоронение.ФИО Get end)

                //  *** End programmer edit section *** (Захоронение.ФИО Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.ФИО Set start)

                //  *** End programmer edit section *** (Захоронение.ФИО Set start)
                this.fФИО = value;
                //  *** Start programmer edit section *** (Захоронение.ФИО Set end)

                //  *** End programmer edit section *** (Захоронение.ФИО Set end)
            }
        }
        
        /// <summary>
        /// ДатаРождения.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.ДатаРождения CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.ДатаРождения CustomAttributes)
        public virtual System.DateTime ДатаРождения
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.ДатаРождения Get start)

                //  *** End programmer edit section *** (Захоронение.ДатаРождения Get start)
                System.DateTime result = this.fДатаРождения;
                //  *** Start programmer edit section *** (Захоронение.ДатаРождения Get end)

                //  *** End programmer edit section *** (Захоронение.ДатаРождения Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.ДатаРождения Set start)

                //  *** End programmer edit section *** (Захоронение.ДатаРождения Set start)
                this.fДатаРождения = value;
                //  *** Start programmer edit section *** (Захоронение.ДатаРождения Set end)

                //  *** End programmer edit section *** (Захоронение.ДатаРождения Set end)
            }
        }
        
        /// <summary>
        /// ДатаСмерти.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.ДатаСмерти CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.ДатаСмерти CustomAttributes)
        public virtual System.DateTime ДатаСмерти
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.ДатаСмерти Get start)

                //  *** End programmer edit section *** (Захоронение.ДатаСмерти Get start)
                System.DateTime result = this.fДатаСмерти;
                //  *** Start programmer edit section *** (Захоронение.ДатаСмерти Get end)

                //  *** End programmer edit section *** (Захоронение.ДатаСмерти Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.ДатаСмерти Set start)

                //  *** End programmer edit section *** (Захоронение.ДатаСмерти Set start)
                this.fДатаСмерти = value;
                //  *** Start programmer edit section *** (Захоронение.ДатаСмерти Set end)

                //  *** End programmer edit section *** (Захоронение.ДатаСмерти Set end)
            }
        }
        
        /// <summary>
        /// НаличиеОграды.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.НаличиеОграды CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.НаличиеОграды CustomAttributes)
        public virtual bool НаличиеОграды
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.НаличиеОграды Get start)

                //  *** End programmer edit section *** (Захоронение.НаличиеОграды Get start)
                bool result = this.fНаличиеОграды;
                //  *** Start programmer edit section *** (Захоронение.НаличиеОграды Get end)

                //  *** End programmer edit section *** (Захоронение.НаличиеОграды Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.НаличиеОграды Set start)

                //  *** End programmer edit section *** (Захоронение.НаличиеОграды Set start)
                this.fНаличиеОграды = value;
                //  *** Start programmer edit section *** (Захоронение.НаличиеОграды Set end)

                //  *** End programmer edit section *** (Захоронение.НаличиеОграды Set end)
            }
        }
        
        /// <summary>
        /// Фото.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.Фото CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.Фото CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.WebFile Фото
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.Фото Get start)

                //  *** End programmer edit section *** (Захоронение.Фото Get start)
                ICSSoft.STORMNET.UserDataTypes.WebFile result = this.fФото;
                //  *** Start programmer edit section *** (Захоронение.Фото Get end)

                //  *** End programmer edit section *** (Захоронение.Фото Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.Фото Set start)

                //  *** End programmer edit section *** (Захоронение.Фото Set start)
                this.fФото = value;
                //  *** Start programmer edit section *** (Захоронение.Фото Set end)

                //  *** End programmer edit section *** (Захоронение.Фото Set end)
            }
        }
        
        /// <summary>
        /// СостояниеЗахоронения.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.СостояниеЗахоронения CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.СостояниеЗахоронения CustomAttributes)
        public virtual IIS.SmartMogila.СостояниеЗахоронения СостояниеЗахоронения
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.СостояниеЗахоронения Get start)

                //  *** End programmer edit section *** (Захоронение.СостояниеЗахоронения Get start)
                IIS.SmartMogila.СостояниеЗахоронения result = this.fСостояниеЗахоронения;
                //  *** Start programmer edit section *** (Захоронение.СостояниеЗахоронения Get end)

                //  *** End programmer edit section *** (Захоронение.СостояниеЗахоронения Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.СостояниеЗахоронения Set start)

                //  *** End programmer edit section *** (Захоронение.СостояниеЗахоронения Set start)
                this.fСостояниеЗахоронения = value;
                //  *** Start programmer edit section *** (Захоронение.СостояниеЗахоронения Set end)

                //  *** End programmer edit section *** (Захоронение.СостояниеЗахоронения Set end)
            }
        }
        
        /// <summary>
        /// СостояниеНадгробия.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.СостояниеНадгробия CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.СостояниеНадгробия CustomAttributes)
        public virtual IIS.SmartMogila.СостояниеЗахоронения СостояниеНадгробия
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.СостояниеНадгробия Get start)

                //  *** End programmer edit section *** (Захоронение.СостояниеНадгробия Get start)
                IIS.SmartMogila.СостояниеЗахоронения result = this.fСостояниеНадгробия;
                //  *** Start programmer edit section *** (Захоронение.СостояниеНадгробия Get end)

                //  *** End programmer edit section *** (Захоронение.СостояниеНадгробия Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.СостояниеНадгробия Set start)

                //  *** End programmer edit section *** (Захоронение.СостояниеНадгробия Set start)
                this.fСостояниеНадгробия = value;
                //  *** Start programmer edit section *** (Захоронение.СостояниеНадгробия Set end)

                //  *** End programmer edit section *** (Захоронение.СостояниеНадгробия Set end)
            }
        }
        
        /// <summary>
        /// КоординатыЗахоронения.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.КоординатыЗахоронения CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.КоординатыЗахоронения CustomAttributes)
        public virtual double КоординатыЗахоронения
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.КоординатыЗахоронения Get start)

                //  *** End programmer edit section *** (Захоронение.КоординатыЗахоронения Get start)
                double result = this.fКоординатыЗахоронения;
                //  *** Start programmer edit section *** (Захоронение.КоординатыЗахоронения Get end)

                //  *** End programmer edit section *** (Захоронение.КоординатыЗахоронения Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.КоординатыЗахоронения Set start)

                //  *** End programmer edit section *** (Захоронение.КоординатыЗахоронения Set start)
                this.fКоординатыЗахоронения = value;
                //  *** Start programmer edit section *** (Захоронение.КоординатыЗахоронения Set end)

                //  *** End programmer edit section *** (Захоронение.КоординатыЗахоронения Set end)
            }
        }
        
        /// <summary>
        /// Захоронение.
        /// </summary>
        //  *** Start programmer edit section *** (Захоронение.Квартал CustomAttributes)

        //  *** End programmer edit section *** (Захоронение.Квартал CustomAttributes)
        [NotNull()]
        public virtual IIS.SmartMogila.Квартал Квартал
        {
            get
            {
                //  *** Start programmer edit section *** (Захоронение.Квартал Get start)

                //  *** End programmer edit section *** (Захоронение.Квартал Get start)
                IIS.SmartMogila.Квартал result = this.fКвартал;
                //  *** Start programmer edit section *** (Захоронение.Квартал Get end)

                //  *** End programmer edit section *** (Захоронение.Квартал Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Захоронение.Квартал Set start)

                //  *** End programmer edit section *** (Захоронение.Квартал Set start)
                this.fКвартал = value;
                //  *** Start programmer edit section *** (Захоронение.Квартал Set end)

                //  *** End programmer edit section *** (Захоронение.Квартал Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗахоронениеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗахоронениеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗахоронениеE", typeof(IIS.SmartMogila.Захоронение));
                }
            }
            
            /// <summary>
            /// "ЗахоронениеL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗахоронениеL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗахоронениеL", typeof(IIS.SmartMogila.Захоронение));
                }
            }
        }
    }
}
