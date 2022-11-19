Feature: CommandActionTest

@Target:API @Target:Chrome @Target:Firefox @Set1
Scenario: No Command Action Tag
Then The command action is set to Default


@Target:API @Target:Chrome @Target:Firefox @ForceAPI @Set1
Scenario: ForceAPI Command Action Tag
Then The command action is set to ForceApi

@Target:API @Target:Chrome @Target:Firefox @ForceBrowser @Set1
Scenario: ForceBrowser Command Action Tag
Then The command action is set to ForceBrowser

@Target:API @Target:Chrome @Target:Firefox @PreferAPI @Set1
Scenario: PreferApi Command Action Tag
Then The command action is set to PreferApi

@Target:API @Target:Chrome @Target:Firefox @PreferBrowser @Set1
Scenario: PreferBrowser Command Action Tag
Then The command action is set to PreferBrowser