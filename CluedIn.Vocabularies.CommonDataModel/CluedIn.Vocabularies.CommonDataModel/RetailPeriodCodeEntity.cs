using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPeriodCodeEntityVocabulary : SimpleVocabulary
    {
        public RetailPeriodCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailPeriodCodeEntity";
            KeyPrefix = "commonDataModel.retailperiodcodeentity";
            KeySeparator = ".";
            Grouping = "/RetailPeriodCodeEntity";

            AddGroup("Common Data Model RetailPeriodCodeEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndChange = group.Add(new VocabularyKey(nameof(EndChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndFixedDate = group.Add(new VocabularyKey(nameof(EndFixedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndFunction1 = group.Add(new VocabularyKey(nameof(EndFunction1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndFunction2 = group.Add(new VocabularyKey(nameof(EndFunction2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndPeriod1 = group.Add(new VocabularyKey(nameof(EndPeriod1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndPeriod2 = group.Add(new VocabularyKey(nameof(EndPeriod2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndUnit = group.Add(new VocabularyKey(nameof(EndUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartChange = group.Add(new VocabularyKey(nameof(StartChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartFixedDate = group.Add(new VocabularyKey(nameof(StartFixedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartFunction1 = group.Add(new VocabularyKey(nameof(StartFunction1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartFunction2 = group.Add(new VocabularyKey(nameof(StartFunction2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartPeriod1 = group.Add(new VocabularyKey(nameof(StartPeriod1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartPeriod2 = group.Add(new VocabularyKey(nameof(StartPeriod2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartUnit = group.Add(new VocabularyKey(nameof(StartUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Txt = group.Add(new VocabularyKey(nameof(Txt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Code { get; private set; }
public VocabularyKey EndChange { get; private set; }
public VocabularyKey EndFixedDate { get; private set; }
public VocabularyKey EndFunction1 { get; private set; }
public VocabularyKey EndFunction2 { get; private set; }
public VocabularyKey EndPeriod1 { get; private set; }
public VocabularyKey EndPeriod2 { get; private set; }
public VocabularyKey EndUnit { get; private set; }
public VocabularyKey StartChange { get; private set; }
public VocabularyKey StartFixedDate { get; private set; }
public VocabularyKey StartFunction1 { get; private set; }
public VocabularyKey StartFunction2 { get; private set; }
public VocabularyKey StartPeriod1 { get; private set; }
public VocabularyKey StartPeriod2 { get; private set; }
public VocabularyKey StartUnit { get; private set; }
public VocabularyKey Txt { get; private set; }


    }
}