import { TestBed } from '@angular/core/testing';

import { ComandaProdusServiceService } from './comanda-produs-service.service';

describe('ComandaProdusServiceService', () => {
  let service: ComandaProdusServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComandaProdusServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
