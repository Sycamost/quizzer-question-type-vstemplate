#pragma once
#include <string>
#include <easy_list.h>
#include <fstream>
#include "Question.h"

class $question_type_name$ : public Question
{
private:$field_begin$
	$field_type$ _$field_name$;$field_end$
	void writeChildData(std::wofstream& stream);
public:
	$question_type_name$($field_begin$$field_type$ $field_name$, $field_end$easy_list::list<std::wstring> tags = easy_list::list<std::wstring>());
	std::wstring getQuestion();
	std::wstring getAnswer();
	bool isCorrect(std::wstring guess);
};