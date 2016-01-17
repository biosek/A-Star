using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarRenewed
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 35;
			Mriz.Vrchol[,] pole = new Mriz.Vrchol[n, n];
			for( int i = 0; i < n; i++ )
			{
				for( int j = 0; j < n; j++ )
				{
					pole[i, j] = new Mriz.Vrchol( i, j );
				}
			}

			int k = 5;
			for( int i = 5; i < n - 1; i++ )
			{
				pole[i, k].walkable = false;
				pole[i, k].type = 1;
				pole[i, k + 1].walkable = false;
				pole[i, k + 1].type = 1;
				pole[i, n - i].walkable = false;
				pole[i, n - i].type = 1;
				pole[i, n - i + 1].walkable = false;
				pole[i, n - i + 1].type = 1;
				k++;
			}

			List<Mriz.Vrchol> pom = Mriz.PathFind( pole[0, 0], pole[18, 20], pole, n );
			if( pom != null )
				foreach( Mriz.Vrchol item in pom )
				{
					item.type = 2;
				}
			else Console.WriteLine( "Cesta nenalezena" );


			for( int i = 0; i < n; i++ )
			{
				for( int j = 0; j < n; j++ )
				{
					switch( pole[i, j].type )
					{
						case 0:
							Console.Write( ". " );
							break;
						case 1:
							Console.Write( "x " );
							break;
						case 2:
							Console.Write( "* " );
							break;
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine( "Konec" );
			Console.ReadLine();
		}
	}
}
