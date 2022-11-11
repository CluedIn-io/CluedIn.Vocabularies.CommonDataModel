using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25StdExpressionLineEntityVocabulary : SimpleVocabulary
    {
        public RTax25StdExpressionLineEntityVocabulary()
        {
            VocabularyName = "RTax25StdExpressionLineEntity";
            KeyPrefix = "commonDataModel.rtax25stdexpressionlineentity";
            KeySeparator = ".";
            Grouping = "/RTax25StdExpressionLineEntity";

            AddGroup("RTax25StdExpressionLineEntity Details", group =>
            {
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Operator = group.Add(new VocabularyKey(nameof(Operator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Index = group.Add(new VocabularyKey(nameof(Index), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                From = group.Add(new VocabularyKey(nameof(From), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitId = group.Add(new VocabularyKey(nameof(ProfitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterField = group.Add(new VocabularyKey(nameof(RegisterField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                To = group.Add(new VocabularyKey(nameof(To), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Output = group.Add(new VocabularyKey(nameof(Output), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTypes = group.Add(new VocabularyKey(nameof(PeriodTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey Operator { get; private set; }
        public VocabularyKey Index { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey ProfitId { get; private set; }
        public VocabularyKey RegisterField { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey Output { get; private set; }
        public VocabularyKey PeriodTypes { get; private set; }


    }
}