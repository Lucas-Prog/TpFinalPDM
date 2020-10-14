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
        public string Name { get; set; }
        public float Wheight { get; set; }
        public string ProdName { get; set; }
        public string ProdEmail { get; set; }
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
