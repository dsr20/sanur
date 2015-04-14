
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IMedicoCAD
{
MedicoEN ReadOIDDefault (int idUsuario);

int New_ (MedicoEN medico);

void Modify (MedicoEN medico);


void Destroy (int idUsuario);


MedicoEN ReadOID (int idUsuario);


System.Collections.Generic.IList<MedicoEN> ReadAll (int first, int size);
}
}
