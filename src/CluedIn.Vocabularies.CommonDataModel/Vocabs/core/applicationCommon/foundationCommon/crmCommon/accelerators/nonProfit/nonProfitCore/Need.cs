using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class NeedVocabulary : SimpleVocabulary
    {
        public NeedVocabulary()
        {
            VocabularyName = "Need";
            KeyPrefix = "commonDataModel.need.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Need";

            AddGroup("Need Details for NonProfitCore", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Need Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NeedId = group.Add(new VocabularyKey(nameof(NeedId), "Need", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NeedType = group.Add(new VocabularyKey(nameof(NeedType), "Need Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Severitytype = group.Add(new VocabularyKey(nameof(Severitytype), "Severity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NeedId { get; private set; }
        public VocabularyKey NeedType { get; private set; }
        public VocabularyKey Severitytype { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}