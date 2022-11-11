using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentSegmentEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentSegmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicPaymentSegmentEntity";
            KeyPrefix = "commonDataModel.electronicpaymentsegmententity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentSegmentEntity";

            AddGroup("Common Data Model ElectronicPaymentSegmentEntity Details", group =>
            {
                Segment = group.Add(new VocabularyKey(nameof(Segment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandatory = group.Add(new VocabularyKey(nameof(Mandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextsegment = group.Add(new VocabularyKey(nameof(Nextsegment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Segment { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Mandatory { get; private set; }
        public VocabularyKey Nextsegment { get; private set; }


    }
}