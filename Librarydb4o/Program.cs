using System;
using System.Collections.Generic;
using System.IO;
using Db4objects.Db4o;
using Librarydb4o.Models;

namespace Librarydb4o
{
    public class Program
    {
        private static readonly string Db4ODatabaseFile = $"{Directory.GetCurrentDirectory()}/data.db4o";

        private static void Main(string[] args)
        {
            if (!File.Exists(Db4ODatabaseFile))
            {
                File.Create(Db4ODatabaseFile);
                Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), Db4ODatabaseFile);
            }

            IObjectContainer db = Db4oEmbedded.OpenFile(Db4ODatabaseFile);

            try
            {
                StoreData(db);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void StoreData(IObjectContainer dataSource)
        {
            // Criação de Pessoas
            var person1 = new Person("Diogo Araujo", null, null, null);
            var person2 = new Person("Josue Braz", null, null, null);
            var person3 = new Person("Fabio Carvalho", null, null, null);

            dataSource.Store(person1);
            dataSource.Store(person2);
            dataSource.Store(person3);

            // Criação de Contas
            var account1 = new Account(DateTime.Now, true, AccountType.Personal, person1, new List<Borrow>());
            var account2 = new Account(DateTime.Now, true, AccountType.Personal, person2, new List<Borrow>());
            var account3 = new Account(DateTime.Now, true, AccountType.Personal, person3, new List<Borrow>());

            dataSource.Store(account1);
            dataSource.Store(account2);
            dataSource.Store(account3);

            // Associar a conta às pessoas
            person1.Account = account1;
            person2.Account = account2;
            person3.Account = account3;
            
            var monograph = new Monograph(10, new List<Copy>());
            var monograph1 = new Monograph(15, new List<Copy>());
            var monograph2 = new Monograph(20, new List<Copy>());

            var copyMonograph1 = new Copy(DateTime.Now.AddDays(-7), monograph, new List<Borrow>(), "91000000", "Porto");
            var copyMonograph2 = new Copy(DateTime.Now.AddDays(-14), monograph1, new List<Borrow>(), "91000001",
                "Lisboa");
            var copyMonograph3 = new Copy(DateTime.Now.AddDays(-21), monograph2, new List<Borrow>(), "91000002",
                "Coimbra");

            // Adicionar cópias ao Item
            monograph.Copies.Add(copyMonograph1);
            monograph.Copies.Add(copyMonograph2);
            monograph.Copies.Add(copyMonograph3);

            var borrow1 = new Borrow(DateTime.Now, new DateTime(), copyMonograph1, account1);
            var borrow2 = new Borrow(DateTime.Now, new DateTime(), copyMonograph2, account2);
            var borrow3 = new Borrow(DateTime.Now, new DateTime(), copyMonograph3, account3);
            
            account1.Borrows.Add(borrow1);
            account2.Borrows.Add(borrow2);
            account3.Borrows.Add(borrow3);
            
            copyMonograph1.Borrows.Add(borrow1);
            copyMonograph2.Borrows.Add(borrow2);
            copyMonograph3.Borrows.Add(borrow3);
        }
    }
}