import { TestBed } from '@angular/core/testing';

import { ComandaServiceService } from './comanda-service.service';

describe('ComandaServiceService', () => {
  let service: ComandaServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComandaServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
