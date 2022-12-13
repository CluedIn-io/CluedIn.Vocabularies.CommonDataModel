using System.Collections.Generic;
using System.Text;

namespace CluedIn.Vocabulariess.CDM.CLI.Model
{
    public class VocabInfo
    {
        public string AtCorpusPath { get; set; }
        public string EntityType { get; set; }
        public string EntityTypeName { get; set; }
        public List<GroupProperties> GroupProperties { get; set; } = new List<GroupProperties>();

        public List<string> Keys { get; set; } = new List<string>();

        public StringBuilder IncomingRelationships { get; set; }
        public StringBuilder OutgoingRelationships { get; set; }
    }

    public class GroupProperties
    {
        public string Name { get; set; }
        public string AtCorpusPath { get; set; }
        public List<string> Properties { get; set; }
    }
}
