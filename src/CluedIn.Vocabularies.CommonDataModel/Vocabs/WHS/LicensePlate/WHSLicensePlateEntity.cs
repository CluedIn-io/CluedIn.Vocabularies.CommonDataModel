using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLicensePlateEntityVocabulary : SimpleVocabulary
    {
        public WHSLicensePlateEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLicensePlateEntity";
            KeyPrefix = "commonDataModel.whslicenseplateentity";
            KeySeparator = ".";
            Grouping = "/WHSLicensePlateEntity";

            AddGroup("Common Data Model WHSLicensePlateEntity Details", group =>
            {
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgingDate = group.Add(new VocabularyKey(nameof(AgingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Level = group.Add(new VocabularyKey(nameof(Level), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentLicensePlateNumber = group.Add(new VocabularyKey(nameof(ParentLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LicensePlateNumber { get; private set; }
public VocabularyKey AgingDate { get; private set; }
public VocabularyKey Level { get; private set; }
public VocabularyKey ParentLicensePlateNumber { get; private set; }


    }
}