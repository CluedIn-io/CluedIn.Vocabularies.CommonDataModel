using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VehicleTypeTableEntityVocabulary : SimpleVocabulary
    {
        public VehicleTypeTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model VehicleTypeTableEntity";
            KeyPrefix = "commonDataModel.vehicletypetableentity";
            KeySeparator = ".";
            Grouping = "/VehicleTypeTableEntity";

            AddGroup("Common Data Model VehicleTypeTableEntity Details", group =>
            {
                VehicleType = group.Add(new VocabularyKey(nameof(VehicleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey VehicleType { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}