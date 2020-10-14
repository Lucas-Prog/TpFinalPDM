using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using TpPdmFinal.Data;
using SQLite;
using System.Security.Cryptography;

namespace TpPdmFinal.Model
{
    public class Mercadoria
    {
        public Mercadoria()
        {
            database = DependencyService.Get<ISqLite>().GetConexao();
            database.CreateTable<Mercadoria>();
        }

        #region Propriedades
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
        public float wheight { get; set; }
        public string prodName { get; set; }
        public string prodEmail { get; set; }
        public string NCM { get; set; }
        #endregion

        #region Mercadoria Local Database
        private SQLiteConnection database;
        static object locker = new object();

        public int SalvarMercadoria(Mercadoria mercadoria)
        {
            lock (locker)
            {
                if (mercadoria.Id != 0)
                {
                    database.Update(mercadoria);
                    return mercadoria.Id;
                }
                else return database.Insert(mercadoria);
            }
        }

        public IEnumerable<Mercadoria> GetMercadorias()
        { 
            lock(locker)
            {
                return (from c in database.Table<Mercadoria>() select c).ToList();
            }
        }

        public Mercadoria GetMercadoria(int Id)
        {
            lock (locker)
            {
                return database.Table<Mercadoria>().Where(c => c.Id == Id).FirstOrDefault();
            }
        }

        public int RemoverAluno(int id)
        {
            lock (locker)
            {
                return database.Delete<Mercadoria>(Id);
            }
        }
        #endregion
    }
}