#include "$question_type_name$.h"
#include "$question_type_name$Reader.h"
#include "QuestionReader.h"
#include "Option.h"
#include "QuestionType.h"
#include "globals.h"
#include "util.h"

namespace $question_type_name$Reader
{$field_begin$
	$field_type$ $field_name${ $field_default$ };$field_end$

	enum class Stage {$field_begin$
		$field_enum$,$field_end$
		TAGS
	} stage;

	void clear()
	{$field_begin$
		$field_name$ = $field_default$;$field_end$
	}

	void read(std::wstring line)
	{$field_begin$
		if (stage == Stage::$field_enum$)
		{
			static_assert(false, "$question_type_name$Reader::read() must read in $field_name$.");
			// $field_name$ = parse(line);
			stage = Stage::$next_field_enum$;
			return;
		}$field_end$
	}

	Question* construct(easy_list::list<Option> options, easy_list::list<std::wstring> tags)
	{
		if (stage != Stage::TAGS)
			return nullptr;
		static_assert(false, "Consider the usage of the options variable here.");
		return new $question_type_name$(tags$field_begin$, $field_name$$field_end$);
	}

	QuestionReader& get()
	{
		static QuestionReader reader = QuestionReader(
			&clear,
			&read,
			&construct
		);
		return reader;
	}
}