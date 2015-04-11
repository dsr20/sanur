
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface ITriageCAD
{
TriageEN ReadOIDDefault (int idTriage);

int New_ (TriageEN triage);

void Modify (TriageEN triage);


TriageEN ReadOID (int idTriage);


System.Collections.Generic.IList<TriageEN> ReadAll (int first, int size);
}
}
