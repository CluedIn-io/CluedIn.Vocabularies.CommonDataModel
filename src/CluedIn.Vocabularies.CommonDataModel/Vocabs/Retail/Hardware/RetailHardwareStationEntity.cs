using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailHardwareStationEntityVocabulary : SimpleVocabulary
    {
        public RetailHardwareStationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailHardwareStationEntity";
            KeyPrefix = "commonDataModel.retailhardwarestationentity";
            KeySeparator = ".";
            Grouping = "/RetailHardwareStationEntity";

            AddGroup("Common Data Model RetailHardwareStationEntity Details", group =>
            {
                HardwareStationId = group.Add(new VocabularyKey(nameof(HardwareStationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HardwareStationName = group.Add(new VocabularyKey(nameof(HardwareStationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HardwareProfileId = group.Add(new VocabularyKey(nameof(HardwareProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HardwareStationPortNumber = group.Add(new VocabularyKey(nameof(HardwareStationPortNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SelfServicePackage = group.Add(new VocabularyKey(nameof(SelfServicePackage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SelfServicePackageName = group.Add(new VocabularyKey(nameof(SelfServicePackageName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MergedSelfServicePackageReference = group.Add(new VocabularyKey(nameof(MergedSelfServicePackageReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey HardwareStationId { get; private set; }
public VocabularyKey HardwareStationName { get; private set; }
public VocabularyKey HardwareProfileId { get; private set; }
public VocabularyKey HardwareStationPortNumber { get; private set; }
public VocabularyKey SelfServicePackage { get; private set; }
public VocabularyKey SelfServicePackageName { get; private set; }
public VocabularyKey MergedSelfServicePackageReference { get; private set; }


    }
}