using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsLocationRoleEntityVocabulary : SimpleVocabulary
    {
        public LogisticsLocationRoleEntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsLocationRoleEntity";
            KeyPrefix = "commonDataModel.logisticslocationroleentity";
            KeySeparator = ".";
            Grouping = "/LogisticsLocationRoleEntity";

            AddGroup("Common Data Model LogisticsLocationRoleEntity Details", group =>
            {
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostalAddress = group.Add(new VocabularyKey(nameof(PostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactInfo = group.Add(new VocabularyKey(nameof(ContactInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Purpose { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey PostalAddress { get; private set; }
public VocabularyKey ContactInfo { get; private set; }
public VocabularyKey Language { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}