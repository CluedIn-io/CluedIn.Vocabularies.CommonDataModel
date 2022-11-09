using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBIActivitiesOpenVocabulary : SimpleVocabulary
    {
        public CustCollectionsBIActivitiesOpenVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBIActivitiesOpen";
            KeyPrefix = "commonDataModel.custcollectionsbiactivitiesopen";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBIActivitiesOpen";

            AddGroup("Common Data Model CustCollectionsBIActivitiesOpen Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResponsibleWorker = group.Add(new VocabularyKey(nameof(ResponsibleWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ActivityNumber { get; private set; }
public VocabularyKey AccountNum { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ResponsibleWorker { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey Purpose { get; private set; }
public VocabularyKey TypeId { get; private set; }
public VocabularyKey StartDateTime { get; private set; }
public VocabularyKey EndDateTime { get; private set; }


    }
}