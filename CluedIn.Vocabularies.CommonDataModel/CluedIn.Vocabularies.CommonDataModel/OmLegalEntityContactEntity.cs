using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OmLegalEntityContactEntityVocabulary : SimpleVocabulary
    {
        public OmLegalEntityContactEntityVocabulary()
        {
            VocabularyName = "Common Data Model OmLegalEntityContactEntity";
            KeyPrefix = "commonDataModel.omlegalentitycontactentity";
            KeySeparator = ".";
            Grouping = "/OmLegalEntityContactEntity";

            AddGroup("Common Data Model OmLegalEntityContactEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionCode = group.Add(new VocabularyKey(nameof(CountryRegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Locator = group.Add(new VocabularyKey(nameof(Locator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocatorExtension = group.Add(new VocabularyKey(nameof(LocatorExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsMobilePhone = group.Add(new VocabularyKey(nameof(IsMobilePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrivate = group.Add(new VocabularyKey(nameof(IsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey LocationId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey CountryRegionCode { get; private set; }
public VocabularyKey Locator { get; private set; }
public VocabularyKey LocatorExtension { get; private set; }
public VocabularyKey Purpose { get; private set; }
public VocabularyKey IsMobilePhone { get; private set; }
public VocabularyKey IsPrimary { get; private set; }
public VocabularyKey IsPrivate { get; private set; }
public VocabularyKey DataArea { get; private set; }


    }
}