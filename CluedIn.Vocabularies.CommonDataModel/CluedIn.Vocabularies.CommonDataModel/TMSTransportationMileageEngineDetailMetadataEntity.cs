using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationMileageEngineDetailMetadataEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationMileageEngineDetailMetadataEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationMileageEngineDetailMetadataEntity";
            KeyPrefix = "commonDataModel.tmstransportationmileageenginedetailmetadataentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationMileageEngineDetailMetadataEntity";

            AddGroup("Common Data Model TMSTransportationMileageEngineDetailMetadataEntity Details", group =>
            {
                FieldLookupType = group.Add(new VocabularyKey(nameof(FieldLookupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsMandatoryField = group.Add(new VocabularyKey(nameof(IsMandatoryField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationMileageEngineId = group.Add(new VocabularyKey(nameof(TransportationMileageEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldSequenceNumber = group.Add(new VocabularyKey(nameof(FieldSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FieldLookupType { get; private set; }
public VocabularyKey IsMandatoryField { get; private set; }
public VocabularyKey TransportationMileageEngineId { get; private set; }
public VocabularyKey FieldName { get; private set; }
public VocabularyKey FieldSequenceNumber { get; private set; }


    }
}