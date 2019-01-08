using System;
namespace OOP
{

    public class OOP3
    {

		/*
		 * Model the Product class knowing that:
			a product has a weight
			has a name
			a production date
			an expiration date
			it has a producer
			and it can be in one of categories : Dairy, Fruit, Beverages, Bread
			we also knoow that it expires differently based on the category it belongs to:
			fruits expire in 2 days
			beverages expire in 3 years
			dairy expire in 1 week
			bread expires in 4 days
		 */

		interface IProdProperties
		{
			int ProductWeight { get; set; }
			string ProductName { get; set; }
			string ProducerName { get; set; }
            DateTime ProductionDate { get; set; }
            DateTime ExpirationDate { get; }
		}


        public class Product: Bread, IProdProperties
        {
            public int ProductWeight { get; set; }
			public string ProductName { get; set; }
			public string ProducerName { get; set; }
        }


        public class Dairy
        {
            private DateTime expirationDate;

            private TimeSpan expiryTerm = TimeSpan.FromDays(7);

            public DateTime ProductionDate { get; set; }

			public DateTime ExpirationDate
			{
				get
				{
					{
						expirationDate = ProductionDate.Add(expiryTerm);
					}

					return expirationDate;
				}
			}
            
        }


		public class Fruit
		{
            private DateTime expirationDate;

            internal TimeSpan expiryTerm = TimeSpan.FromDays(2);

			public DateTime ProductionDate { get; set; }

			public DateTime ExpirationDate
			{
				get
				{
					{
						expirationDate = ProductionDate.Add(expiryTerm);
					}

					return expirationDate;
				}
			}
		}


        public class Beverages
        {
			private DateTime expirationDate;

			private int expiryTerm = 3;

            public DateTime ProductionDate { get; set; }

			public DateTime ExpirationDate
			{
				get
				{
					{
						expirationDate = ProductionDate.AddYears(expiryTerm);
					}

					return expirationDate;
				}
			}

		}

		public class Bread
		{
            private DateTime expirationDate;

            internal TimeSpan expiryTerm = TimeSpan.FromDays(4);

			public DateTime ProductionDate { get; set; }

			public DateTime ExpirationDate
			{
				get
				{
					{
						expirationDate = ProductionDate.Add(expiryTerm);
					}

					return expirationDate;
				}
			}
		}



    }
}
