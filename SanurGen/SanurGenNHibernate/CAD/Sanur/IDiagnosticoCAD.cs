
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IDiagnosticoCAD
{
DiagnosticoEN ReadOIDDefault (int idDiagnostico);

int New_ (DiagnosticoEN diagnostico);

void Modify (DiagnosticoEN diagnostico);


DiagnosticoEN ReadOID (int idDiagnostico);


System.Collections.Generic.IList<DiagnosticoEN> ReadAll (int first, int size);


int BuscarUltimo ();
}
}
