using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocAuthorityWebserviceEntityVocabulary : SimpleVocabulary
    {
        public EFDocAuthorityWebserviceEntityVocabulary()
        {
            VocabularyName = "Common Data Model EFDocAuthorityWebserviceEntity";
            KeyPrefix = "commonDataModel.efdocauthoritywebserviceentity";
            KeySeparator = ".";
            Grouping = "/EFDocAuthorityWebserviceEntity";

            AddGroup("Common Data Model EFDocAuthorityWebserviceEntity Details", group =>
            {
                Authority = group.Add(new VocabularyKey(nameof(Authority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnvironmentType = group.Add(new VocabularyKey(nameof(EnvironmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Version = group.Add(new VocabularyKey(nameof(Version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WebServiceType = group.Add(new VocabularyKey(nameof(WebServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Authority { get; private set; }
public VocabularyKey EnvironmentType { get; private set; }
public VocabularyKey Url { get; private set; }
public VocabularyKey Version { get; private set; }
public VocabularyKey WebServiceType { get; private set; }


    }
}