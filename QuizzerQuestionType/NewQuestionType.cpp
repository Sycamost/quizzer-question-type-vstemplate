#include "$question_type_name$.h"
#include "QuestionType.h"

static_assert(false, "Before getting rid of this static assertion, make sure you tick off everything on the following checklist:\n"
	"* Move this file, $question_type_name$Reader.cpp and $question_type_name$Writer.cpp to the correct filters (follow precedent).\n"
	"* Likewise with $question_type_name$.h, $question_type_name$Reader.h and $question_type_name$Writer.h.\n"
	"* Append $question_type_enum$ to the QuestionType enum class.\n"
	"* Fill in the blanks and fix any syntax errors in this file, $question_type_name$.h, $question_type_name$Reader.cpp and $question_type_name$Writer.cpp.\n"
	"* Append a new item to the QuestionTypeInfo list in QuestionTypeInfo.cpp.\n"
	"* Update README.md as appropriate.");

$question_type_name$::$question_type_name$($field_begin$
	$field_type$ $field_name$,$field_end$
	easy_list::list<std::wstring> tags) :
	Question(QuestionType::$question_type_enum$, tags)$field_begin$,
	_$field_name$($field_name$)$field_end$
{
}

std::wstring $question_type_name$::getQuestion()
{
	static_assert(false, "$question_type_name$::getQuestion() has not been implemented yet!");
}

std::wstring $question_type_name$::getAnswer()
{
	static_assert(false, "$question_type_name$::getAnswer() has not been implemented yet!");
}

bool $question_type_name$::isCorrect(std::wstring guess)
{
	static_assert(false, "$question_type_name$::isCorrect() has not been implemented yet!");
}

void $question_type_name$::writeChildData(std::wofstream& stream)
{
	static_assert(false, "Consider whether the following code will lead to appropriate behaviour for $question_type_name$.");
	$field_begin$
	stream << _$field_name$ << L"";$field_end$

}