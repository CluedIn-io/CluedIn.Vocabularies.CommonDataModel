using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class CrsOtherFlagVocabulary : SimpleVocabulary
    {
        public CrsOtherFlagVocabulary()
        {
            VocabularyName = "Crs Other Flag";
            KeyPrefix = "commonDataModel.crsotherflag.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/CrsOtherFlag";

            AddGroup("CrsOtherFlag Details for NonProfitIati", group =>
            {
			    CrsAdditionalOtherflagsId = group.Add(new VocabularyKey(nameof(CrsAdditionalOtherflagsId), "Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CrsOtherFlagId = group.Add(new VocabularyKey(nameof(CrsOtherFlagId), "CRS Other Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FlagApplies = group.Add(new VocabularyKey(nameof(FlagApplies), "Flag Applies", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CrsAdditionalOtherflagsId { get; private set; }
        public VocabularyKey CrsOtherFlagId { get; private set; }
        public VocabularyKey FlagApplies { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}