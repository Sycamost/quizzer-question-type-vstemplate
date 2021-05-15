#include <iostream>
#include <string>
#include <easy_list.h>
#include <Windows.h>
#include <exception>
#include <fstream>
#include "Command.h"
#include "util.h"
#include "$question_type_name$.h"
#include "$question_type_name$Writer.h"
#include "globals.h"
#include "QuestionWriter.h"
#include "Write.h"

namespace $question_type_name$Writer
{
	$field_begin$
	$field_type$ $field_name${ $field_default$ };$field_end$

	enum class Stage {$field_begin$
		$field_enum$,$field_end$
		TAGS
	} stage;

	$field_begin$
	void ask$field_name_capitalised$();$field_end$

	$field_begin$
	bool isValid$field_name_capitalised$(std::wstring input)
	{
		static_assert(false, "isValid$field_name_capitalised$() is not implemented.");
	}
	$field_end$

	$field_begin$
	DEFINE_INPUT_HANDLER_FUNC($field_name$InputHandler)
	{
		if (!isValid$field_name_capitalised$(input))
		{
			ask$field_name_capitalised$();
			return InputHandlerReturns::SUCCESS;
		}

		static_assert(false, "$field_name$InputHandler must assign the input to the value of $field_name$.");
		// $field_name$ = parse(input);
		$call_next_asking_function$;
		return InputHandlerReturns::SUCCESS;
	}
	$field_end$

	$field_begin$
	void ask$field_name_capitalised$()
	{
		static const std::wstring msg = L"$field_display_capitalised$:\t";
		stage = Stage::$field_enum$;
		setInputHandling(msg, &$field_name$InputHandler);
	}
	$field_end$

	void write$question_type_name$()
	{$field_begin$
		$field_name$ = $field_default$;$field_end$

		// Start message to user - make sure to personalise this message for $question_type_name$!
		std::wcout <<
			L"Enter the values for new $question_type_name$'s data and tags.\n"
			<< L"Once you're finished adding tags, leave the next tag blank.\n"
			<< L"Make sure your data inputs are valid."
			// (what does that mean for $question_type_name$?)
			<< L"\nUse <"
			<< toLower(CommandInfo::getFirstCode(CommandType::CANCEL))
			<< L"> to cancel adding the current $question_type_name$.\n\n";

		ask$first_field_name_capitalised$();

		return;
	}

	bool resetLastStep()
	{$field_begin$
		if (stage == Stage::$field_enum$)
		{
			ask$field_name_capitalised$();
			return true;
		}$field_end$
		return false;
	}

	Question* constructCurrent(easy_list::list<std::wstring> tags)
	{
		if (stage != Stage::TAGS)
			return nullptr;
		return new $question_type_name$(tags$field_begin$, $field_name$$field_end$);
	}

	QuestionWriter& get()
	{
		static QuestionWriter writer = QuestionWriter(
			QuestionType::$question_type_enum$,
			&write$question_type_name$,
			&resetLastStep,
			&constructCurrent
		);
		return writer;
	}
}