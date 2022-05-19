using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Encriptacion
{
    public static class Util
    {
        public static string Encripta(string texto)
        { 
            byte [] clave=Encoding.UTF8.GetBytes(texto);


            return Convert.ToBase64String(clave);
        }

        public static string DesEncripta(string texto)
        {
            byte[] clave = Convert.FromBase64String(texto);


            return UTF8Encoding.UTF8.GetString(clave);
        }

        public static void GuardaVariableConfiguracion(string nombreVariable, string valor)
        {
            
//            string encriptado = Libreria.Utils.Util.Encripta(valor);
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            KeyValueConfigurationElement variable = config.AppSettings.Settings[nombreVariable];
//            if (variable == null)
//            {
//                variable = new KeyValueConfigurationElement(nombreVariable, encriptado);
//                config.AppSettings.Settings.Add(variable);
//            }
//            else
//                config.AppSettings.Settings[nombreVariable].Value = encriptado;
//            config.Save(ConfigurationSaveMode.Full);
        }
    }
}
