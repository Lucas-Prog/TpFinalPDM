using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
using TpPdmFinal.Model;

namespace TpPdmFinal.ViewModel
{
    public class Mercadoria_ViewModel
    {
        public Mercadoria_ViewModel() { }
        #region Propriendades
        public string name { get; set; }
        public float wheight { get; set; }
        public string prodName { get; set; }
        public string prodEmail { get; set; }
        public string NCM { get; set; }

        public List<Mercadoria> Mercadorias
        {
            get
            {
                return App.MercadoriaModel.GetMercadorias().ToList();
            }
        }
        #endregion
    }
}
