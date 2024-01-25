import { TestBed } from '@angular/core/testing';

import { ProdusServiceService } from './produs-service.service';

describe('ProdusServiceService', () => {
  let service: ProdusServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProdusServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
