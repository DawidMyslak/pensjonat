﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PensjonatApp.DS;
using PensjonatApp.Tools;


namespace PensjonatApp.Helpers
{
    class UslugiHelper
    {
		/// <summary>
		/// dodaje uslugę o danym typie, terminie do danego pobytu
		/// </summary>
        public static int dodajUsluge(int id_pobytu, DateTime termin, string d_opis, int? id_slownikowe)
        {
            return TablesManager.Manager.UslugiTableAdapter.Insert(id_pobytu, null, d_opis, termin, id_slownikowe);
        }
		/// <summary>
		/// edytuje w usludze o danym id: typ, termin i id pobytu
		/// </summary>
		public static int edytujUsluge(int id_uslugi, int? id_pobytu, DateTime termin, string d_opis, int? id_slownikowe)
		{
			return TablesManager.Manager.UslugiTableAdapter.UpdateQuery(id_pobytu, d_opis, termin, id_slownikowe, id_uslugi);
		}
		/// <summary>
		/// usuwa uslugę o danym id
		/// </summary>
		public static int usunUsluge(int id_uslugi)
		{
			return TablesManager.Manager.UslugiTableAdapter.DeleteById(id_uslugi);
		}
		//przydziały pracownicze
		/// <summary>
		/// edytuje w usludze o danym id: id_pracownika
		/// </summary>
        public static int przydzielPracownika(int id_uslugi, int? id_pracownika)
        {
			return TablesManager.Manager.UslugiTableAdapter.UpdateIdPracownika(id_pracownika, id_uslugi);
        }
		/// <summary>
		/// ustawia w usludze o danym id: id_pracownika na null
		/// </summary>
		public static int usunPracownika(int id_uslugi)
		{
			return przydzielPracownika(id_uslugi, null);
		}
    }
}