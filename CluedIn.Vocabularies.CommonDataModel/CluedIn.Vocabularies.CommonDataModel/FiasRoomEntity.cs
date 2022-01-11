using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasRoomEntityVocabulary : SimpleVocabulary
    {
        public FiasRoomEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiasRoomEntity";
            KeyPrefix = "commonDataModel.fiasroomentity";
            KeySeparator = ".";
            Grouping = "/FiasRoomEntity";

            AddGroup("Common Data Model FiasRoomEntity Details", group =>
            {
                RoomId = group.Add(new VocabularyKey(nameof(RoomId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoomGuid = group.Add(new VocabularyKey(nameof(RoomGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegionCode = group.Add(new VocabularyKey(nameof(RegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HouseGuid = group.Add(new VocabularyKey(nameof(HouseGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FlatNumber = group.Add(new VocabularyKey(nameof(FlatNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FlatType = group.Add(new VocabularyKey(nameof(FlatType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RoomId { get; private set; }
public VocabularyKey RoomGuid { get; private set; }
public VocabularyKey RegionCode { get; private set; }
public VocabularyKey HouseGuid { get; private set; }
public VocabularyKey FlatNumber { get; private set; }
public VocabularyKey FlatType { get; private set; }
public VocabularyKey PostalCode { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }


    }
}