using System.Collections.Generic;
namespace oppgaveGurusoft{
    public class Organisasjonsform{
        public string kode { get; set; }
        public string beskrivelse  { get; set; }
        public Links _links { get; set; }
    }
    public class Links{
        public Self self { get; set; }
    }
     public class Self{
        public string href { get; set; }
    }
    public class Naeringskode1{
        public string beskrivelse { get; set; }
        public string kode { get; set; }
    }
    public class Forretningsadresse{
        public string land { get; set; }
        public string landkode { get; set; }
        public string postnummer { get; set; }
        public string poststed { get; set; }
        public List<string> adresse { get; set; }
        public string kommune { get; set; }
        public string kommunenummer { get; set; }
    }
    public class InstitusjonellSektorkode{
        public string kode { get; set; }
        public string beskrivelse { get; set; }
    }
    public class RootObject{
        public string organisasjonsnummer { get; set; }
        public string navn { get; set; }
        public Organisasjonsform organisasjonsform { get; set; }
        public string hjemmeside { get; set; }
        public string registreringsdatoEnhetsregisteret { get; set; }
        public bool registrertIMvaregisteret { get; set; }
        public Naeringskode1 naeringskode1 { get; set; }
        public int antallAnsatte { get; set; }
        public Forretningsadresse forretningsadresse { get; set; }
        public string stiftelsesdato { get; set; }
        public InstitusjonellSektorkode institusjonellSektorkode { get; set; }
        public bool registrertIForetaksregisteret { get; set; }
        public bool registrertIStiftelsesregisteret { get; set; }
        public bool registrertIFrivillighetsregisteret { get; set; }
        public string sisteInnsendteAarsregnskap { get; set; }
        public bool konkurs { get; set; }
        public bool underAvvikling { get; set; }
        public bool underTvangsavviklingEllerTvangsopplosning { get; set; }
        public string maalform { get; set; }
        public Links _links { get; set; }
    }
}