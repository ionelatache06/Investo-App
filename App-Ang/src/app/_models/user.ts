import { Photo } from './photo';

export interface User {
  id: number;
  username: string;
  type: string;
  knownAs: string;
  yearsActive: number;
  createdAt: Date;
  lastActive: Date;
  photoUrl: string;
  city: string;
  country: string;
  description?: string;
  photos?: Photo[];
}


