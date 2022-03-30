﻿using DOPYAO_ADT_2021_22_2.Models;

namespace DOPYAO_ADT_2021_22_2.Repository
{
	public interface IShelterRepository: IRepository<Shelter>
	{
		void ChangeAddress(int id, string newCity, string newAddress);
	
	}
}