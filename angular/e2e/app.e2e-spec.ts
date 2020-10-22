import { boiler-plate-core-angularTemplatePage } from './app.po';

describe('boiler-plate-core-angular App', function() {
  let page: boiler-plate-core-angularTemplatePage;

  beforeEach(() => {
    page = new boiler-plate-core-angularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
