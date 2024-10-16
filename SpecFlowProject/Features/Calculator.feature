Feature: MyLibrary

@AddMedia
Scenario: Add one media
	Given Create Library
	And Create this media :
	| m_Titre         | m_NumeroReference | m_NombreExemplairesDisponibles |
	| "Media de test" | 150291            | 26                             |
	When Add this media in library
	Then The library contain media :
	| m_Titre         | m_NumeroReference | m_NombreExemplairesDisponibles |
	| "Media de test" | 150291            | 26                             |