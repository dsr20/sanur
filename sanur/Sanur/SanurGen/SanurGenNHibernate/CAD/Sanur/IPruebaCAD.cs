
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IPruebaCAD
{
PruebaEN ReadOIDDefault (string idPrueba);

string New_ (PruebaEN prueba);

void Modify (PruebaEN prueba);


PruebaEN ReadOID (string idPrueba);


System.Collections.Generic.IList<PruebaEN> ReadAll (int first, int size);
}
}
