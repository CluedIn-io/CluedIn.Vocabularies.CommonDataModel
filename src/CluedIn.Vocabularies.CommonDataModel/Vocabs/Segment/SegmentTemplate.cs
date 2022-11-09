using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SegmentTemplateVocabulary : SimpleVocabulary
    {
        public SegmentTemplateVocabulary()
        {
            VocabularyName = "Common Data Model SegmentTemplate";
            KeyPrefix = "commonDataModel.segmenttemplate";
            KeySeparator = ".";
            Grouping = "/SegmentTemplate";

            AddGroup("Common Data Model SegmentTemplate Details", group =>
            {
                segmentName = group.Add(new VocabularyKey(nameof(segmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
segmentTemplateId = group.Add(new VocabularyKey(nameof(segmentTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
segmentfilterquery = group.Add(new VocabularyKey(nameof(segmentfilterquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
segmentmemberids = group.Add(new VocabularyKey(nameof(segmentmemberids), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
segmentquery = group.Add(new VocabularyKey(nameof(segmentquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
segmentType = group.Add(new VocabularyKey(nameof(segmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
queryType = group.Add(new VocabularyKey(nameof(queryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
tag = group.Add(new VocabularyKey(nameof(tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
label = group.Add(new VocabularyKey(nameof(label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey segmentName { get; private set; }
public VocabularyKey segmentTemplateId { get; private set; }
public VocabularyKey entityImage { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey segmentfilterquery { get; private set; }
public VocabularyKey segmentmemberids { get; private set; }
public VocabularyKey segmentquery { get; private set; }
public VocabularyKey segmentType { get; private set; }
public VocabularyKey queryType { get; private set; }
public VocabularyKey language { get; private set; }
public VocabularyKey tag { get; private set; }
public VocabularyKey label { get; private set; }


    }
}