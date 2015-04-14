
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IDiagnosticoCAD
{
DiagnosticoEN ReadOIDDefault (string idDiagnostico);

string New_ (DiagnosticoEN diagnostico);

void Modify (DiagnosticoEN diagnostico);


DiagnosticoEN ReadOID (string idDiagnostico);


System.Collections.Generic.IList<DiagnosticoEN> ReadAll (int first, int size);
}
}
