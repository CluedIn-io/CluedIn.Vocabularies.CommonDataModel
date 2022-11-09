using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LayoutVocabulary : SimpleVocabulary
    {
        public LayoutVocabulary()
        {
            VocabularyName = "Common Data Model Layout";
            KeyPrefix = "commonDataModel.layout";
            KeySeparator = ".";
            Grouping = "/Layout";

            AddGroup("Common Data Model Layout Details", group =>
            {
                capacity = group.Add(new VocabularyKey(nameof(capacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disabledAccess = group.Add(new VocabularyKey(nameof(disabledAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disabledCapacity = group.Add(new VocabularyKey(nameof(disabledCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
floorPlan = group.Add(new VocabularyKey(nameof(floorPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
layoutId = group.Add(new VocabularyKey(nameof(layoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
units = group.Add(new VocabularyKey(nameof(units), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
usableArea = group.Add(new VocabularyKey(nameof(usableArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey capacity { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey disabledAccess { get; private set; }
public VocabularyKey disabledCapacity { get; private set; }
public VocabularyKey floorPlan { get; private set; }
public VocabularyKey layoutId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey units { get; private set; }
public VocabularyKey usableArea { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}